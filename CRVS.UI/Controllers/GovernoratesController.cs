﻿using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.OleDb;

namespace CRVS.UI.Controllers
{
    public class GovernoratesController : Controller
    {
        public IBaseRepository<Governorate> repository;
        private IWebHostEnvironment Environment;
        private IConfiguration Configuration;
        public GovernoratesController(IBaseRepository<Governorate> _repository, IWebHostEnvironment environment, IConfiguration _configuration)
        {

            repository = _repository;
            Environment = environment;  
            Configuration = _configuration;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());

        }
        /// <summary>
        /// /////////////////create governorate
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()

        {


            return View();

        }
        [HttpPost]
        public IActionResult Create(Governorate governorate)

        {

            repository.Add(governorate);

            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Edit(int id)

        {



            if (id == null)
            {

                return RedirectToAction("Index");

            }
            var custom = repository.GetById(id);

            if (custom == null)
            {
                return RedirectToAction("NotFoundCustomer");
            }

            return View(custom);

        }


        [HttpPost]
        public IActionResult Edit(int id, Governorate governorate)

        {
        //var data=    repository.GetById(id);
        //    data.GovernorateName = governorate.GovernorateName;
        repository.Update(id, governorate);
            //repository.SaveChanges();
          


            return RedirectToAction(nameof(Index));
        }




        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null || repository.GetById(id) == null)
            {
                return RedirectToAction(nameof(Index));
            }

           

            return View(repository.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            if (id == null || repository.GetById(id) == null)
            {
                return RedirectToAction(nameof(Index));
            }



            return View(repository.GetById(id));
        }

        [HttpGet]
        public IActionResult Import()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Import(IFormFile postedFile)
        {
            try
            {

                if (postedFile != null)
                {
                    //Create a Folder.
                    string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);

                    }

                    //Save the uploaded Excel file.
                    string fileName = Path.GetFileName(postedFile.FileName);
                    string filePath = Path.Combine(path, fileName);
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        postedFile.CopyTo(stream);
                    }

                    //Read the connection string for the Excel file.
                    string conString = this.Configuration.GetConnectionString("excelconnection");
                    DataTable dt = new DataTable();
                    conString = string.Format(conString, filePath);

                    using (OleDbConnection connExcel = new OleDbConnection(conString))
                    {
                        using (OleDbCommand cmdExcel = new OleDbCommand())
                        {
                            using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                            {
                                cmdExcel.Connection = connExcel;

                                //Get the name of First Sheet.
                                connExcel.Open();
                                DataTable dtExcelSchema;
                                dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                                string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                                connExcel.Close();

                                //Read Data from First Sheet.
                                connExcel.Open();
                                cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                                odaExcel.SelectCommand = cmdExcel;
                                odaExcel.Fill(dt);
                                connExcel.Close();
                            }
                        }
                    }

                    //Insert the Data read from the Excel file to Database Table.
                    conString = this.Configuration.GetConnectionString("DefaultConnection");
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            //Set the database table name.
                            sqlBulkCopy.DestinationTableName = "dbo.Governorates";

                            //[OPTIONAL]: Map the Excel columns with that of the database table.
                            sqlBulkCopy.ColumnMappings.Add("id", "GovernorateId");
                            sqlBulkCopy.ColumnMappings.Add("name", "GovernorateName");
                          
                            con.Open();
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();

                            DeleteAllFiles();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the deletion process
                return Content($"An error occurred: {ex.Message}");
            }

            return RedirectToAction("Index", "Governorates");
        }
        public IActionResult DeleteAllFiles()
        {
            // Get the path to the upload folder
            string uploadFolderPath = Path.Combine(this.Environment.WebRootPath, "Uploads");

            {
                try
                {
                    // Check if the upload folder exists
                    if (Directory.Exists(uploadFolderPath))
                    {
                        // Get all file paths inside the upload folder
                        string[] files = Directory.GetFiles(uploadFolderPath);

                        // Loop through the files and delete each one
                        foreach (var file in files)
                        {
                            System.IO.File.Delete(file);
                        }

                        // Optionally, you may also delete any subdirectories within the upload folder
                        // Directory.Delete(uploadFolderPath, true);
                    }

                    // Optionally, you may return a success message or redirect to another page
                    // return RedirectToAction("Index", "Home");
                    return Content("All files inside the Uploads folder have been deleted.");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the deletion process
                    return Content($"An error occurred: {ex.Message}");
                }
            }
        }


    }


}





    
    