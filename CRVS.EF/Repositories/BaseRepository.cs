using CRVS.Core.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

       
      
        public  ApplicationDbContext _context;
        public BaseRepository( ApplicationDbContext context)
        {
                    
             _context = context;
        }




        public void Add(T model)
        {
           _context.Set<T>().Add(model);
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
                if(entity != null)
            {
                _context.Set<T>().Remove(entity);
                SaveChanges();
            }
           
        }

        public IEnumerable<T> GetAll()
        {
            return  _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
          return await _context.Set<T>().ToListAsync();

           
        }

        public T GetById(int id)
        {
            var data = _context.Set<T>().Find(id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var data =  await _context.Set<T>().FindAsync(id);
            if (data != null)
            {
                return data;
            }
            return null!;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(int id, T model)
        {
                _context.Set<T>().Update(model);
                SaveChanges();
            }
      
    }
}
