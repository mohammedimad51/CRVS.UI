using CRVS.Core.Models.SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class BirthCertificate : CommonProp
    {

        public Guid BirthCertificateId { get; set; }
        [Required]
        [Display(Name = "  رقم الشهادة")]
        public string? CertificateNo { get; set; }

        [Display(Name = "   الرقم الصحي")]
        public string? HealthID { get; set; }
        [Required]
        [Display(Name = "الاسم")]
        public string? ChildName { get; set; }
        [Required]
        [Display(Name = "الجنس")]
        public Genders Gender { get; set; }

        [Required]
        [Display(Name = "المحافظة")]
        public string? GovernorateID { get; set; }

        [Required]
        [Display(Name = "دائرة الصحة")]
        public string? DohID { get; set; }
        [Required]
        [Display(Name = "القضاء")]
        public string? DistrictID { get; set; }
        [Required]
        [Display(Name = "ناحية")]
        public string? NahiaID { get; set; }
        [Required]
        [Display(Name = "القرية او الحي")]
        public string? VillageID { get; set; }


        [Required]
        [Display(Name = "الولادة")]
        public BirthTypes BirthType { get; set; }
      
        [Required]
        [Display(Name = "نوع الولادة")]
        public NumberOfBirths NumberOfBirth { get; set; }
       
        [Required]
        [Display(Name = " الساعة")]
        public TimeSpan BHour { get; set; }
        [Required]
        [Display(Name = " تاريخ الميلاد")]
        public DateTime BOD { get; set; }

        [Required]
        [Display(Name = " تاريخ الميلاد كتابتا")]
        public string? BODText { get; set; }

        [Required]
        [Display(Name = "الاسم الاول للاب")]
        public string? FatherFName { get; set; }

        [Required]
        [Display(Name = "الاسم الثاني للاب")]
        public string? FatherMName { get; set; }
        [Required]
        [Display(Name = "الاسم الثالث للاب")]
        public string? FatherLName { get; set; }

        public string? FatherFullName { get; set; }
        [Required]
        [Display(Name = "مواليد الاب")]
        public DateTime FatherBOD { get; set; }
        [Required]
        [Display(Name = "عمر الاب")]
        public int FatherAge { get; set; }
        [Required]
        [Display(Name = "مهنة الاب")]
        [ForeignKey("Job")]
        public int FatherJob { get; set; }
        public Job? Job { get; set; }
        [Required]
        [Display(Name = "جنسية الاب")]
        public int FatherNationality { get; set; }
        [Required]
        [Display(Name = "ديانة الاب")]
        public int FatherReligion { get; set; }

        [Required]
        [Display(Name = "مبايل الاب")]
        public string? FatherMobile { get; set; }

        ////
        ///
        [Required]
        [Display(Name = "الاسم الاول للام")]
        public string? MotherFName { get; set; }

        [Required]
        [Display(Name = "الاسم الثاني للام")]
        public string? MotherMName { get; set; }
        [Required]
        [Display(Name = "الاسم الثالث للام")]
        public string? MotherLName { get; set; }
        public string? MotherFullName { get; set; }
        [Required]
        [Display(Name = "مواليد للام")]
        public DateTime MotherBOD { get; set; }
        [Required]
        [Display(Name = "عمر للام")]
        public int MotherAge { get; set; }
        [Required]
        [Display(Name = "مهنة للام")]
        public int MotherJob { get; set; }
                             
        [Required]
        [Display(Name = "جنسية للام")]
        public int MotherNationality { get; set; }
        [Required]
        [Display(Name = "ديانة للام")]
        public int MotherReligion { get; set; }

        [Required]
        [Display(Name = "مبايل للام")]
        public string? MotherMobile { get; set; }


        [Required]
        [Display(Name = "صلة القرابة")]
        public bool Relative { get; set; }


        [Required]
        [Display(Name = "على قيد الحياة")]
        public int Alive { get; set; } = 0;


        [Required]
        [Display(Name = "المولودون احياء ثم توفوا")]
        public int BornAliveThenDied { get; set; } = 0;


        [Required]
        [Display(Name = "الذين ولدوا امواتاً")]
        public int StillBirth { get; set; } = 0;



        [Required]
        [Display(Name = "الذين ولدوا معوقين")]
        public int BornDisable { get; set; } = 0;


        [Required]
        [Display(Name = "عدد الاسقاطات ان وجدت")]
        public int NoAbortion { get; set; } = 0;


        [Required]
        [Display(Name = "هل الولادة الحالية معوقة")]
        public bool IsDisabled { get; set; }

        [Required]
        [Display(Name = "حدد نوع العوق")]
        public string? IsDisabledType { get; set; }


        [Required]
        [Display(Name = "مدة الحمل")]
        public bool DurationOfPregnancy { get; set; }


        [Required]
        [Display(Name = "وزن الطفل")]
        public Decimal BabyWeight { get; set; } 

         [Required]
         [Display(Name = " مكان الولادة")]
         public PlaceOfBirths PlaceOfBirth { get; set; }

         [Required]
          [Display(Name = " حدثت الولادة بواسطت")]
         public BirthOccurredBys BirthOccurredBy { get; set; }


        [Display(Name = "   رقم الاجازة")]
        public string? LicenseNo { get; set; }


        [Display(Name = "   تاريخ الاجازة")]
        public DateTime LicenseYear { get; set; }



        [Required]
        [Display(Name = "المحافظة")]
        public string? FamilyGovernorate { get; set; }

        [Required]
        [Display(Name = "دائرة الصحة")]
        public string? FamilyDOH { get; set; }
        [Required]
        [Display(Name = "القضاء")]
        public string? FamilyDistrict { get; set; }
        [Required]
        [Display(Name = "ناحية")]
        public string? FamilyNahia { get; set; }
        [Required]
        [Display(Name = "المحلة")]
        public string? FamilyMahala { get; set; }

        [Required]
        [Display(Name = "القطاع")]
        public string? FamilySector { get; set; }
        [Required]
        [Display(Name = "مركز صحي")]
        public string? FamilyPHC { get; set; }

        [Display(Name = "الزقاق")]
        public string? FamilyZigag { get; set; }


        [Display(Name = "رقم الدار")]
        public string? FamilyHomeNo { get; set; }

        [Required]
        [Display(Name = "نوع الهوية")]
        public DocumentTypes DocumentType { get; set; }

        [Display(Name = "رقم السجل ")]
        public string? RecordNumber { get; set; }

        [Display(Name = " رقم الصحيفة ")]
        public string? PageNumber { get; set; }

        [Display(Name = " مديرية الأحوال المدنية ")]
        public string? CivilStatusDirectorate { get; set; }
        [Display(Name = " المحافظة ")]
        public string? GovernorateCivilStatusDirectorate { get; set; }
        [Display(Name = " البطاقة الوطنية الموحدة ")]
        public NationalIdFors NationalIdFor { get; set; }

        [Display(Name = "الرقم الوطني الموحد")]
        public string? NationalID { get; set; }

        [Display(Name = "جواز السفر")]
        public string? PassportNo { get; set; }


        [Display(Name = "اسم المخبر")]
        public string? InformerName { get; set; }

        [Display(Name = "عنوانه")]
        public string? InformerJobTitle { get; set; }

        [Display(Name = "صلته بالوليد")]
        public string? KinshipOfTheNewborn { get; set; }

        [Display(Name = "اسم المولد")]
        public string? BirthPerformerName { get; set; }


        [Display(Name = "عنوان الاشتغال")]
        public string? BirthPerformerWorkingAddress { get; set; }

        [Display(Name = " مدير المؤسسة الصحية")]
        public string? HospitalManagerName { get; set; }



        [Display(Name = "التوقيع والختم")]
        public string? HospitalManagerSig { get; set; }

        [Display(Name = "رقم التموين")]
        public string? RationCard { get; set; }

        [Required]
        [Display(Name = "نسخة من الشهادة الورقية")]
        public string? ImgBirthCertificate { get; set; }



        [Display(Name = "نسخة من عقد الزواج")]
        public string? ImgMarriageCertificate { get; set; }

        [Required]
        [Display(Name = "هوية الاب:الوجه الاول")]
        public string? ImgFatherUnifiedNationalIdFront { get; set; }


        [Required]
        [Display(Name = "هوية الاب:الوجه الثاني")]
        public string? ImgFatherUnifiedNationalIdBack { get; set; }

        [Required]
        [Display(Name = "هوية الام:الوجه الاول")]
        public string? ImgMotherUnifiedNationalIdFront { get; set; }

        [Required]
        [Display(Name = "هوية الام:الوجه الثاني")]
        public string? ImgMotherUnifiedNationalIdBack { get; set; }


        [Required]
        [Display(Name = "بطاقة السكن:الوجه الاول")]
        public string? ImgResidencyCardFront { get; set; }

        [Required]
        [Display(Name = "بطاقة السكن:الوجه الثاني")]
        public string? ImgResidencyCardBack { get; set; }



        [Display(Name = "المرفقات")]
        public string? AllPDFs { get; set; }

        [Display(Name = "QR")]
        public string? QrCode { get; set; }

        [Display(Name = "منشيء الاستمارة")]
        public string? Creator { get; set; }

        [Display(Name = "الحفظ والارسال")]
        public bool FirstStage { get; set; }

        [Display(Name = "التدقيق والارسال")]
        public bool SecondStage { get; set; }

        [Display(Name = "التدقيق و الحفظ النهائي")]
        public string? Approval { get; set; }


    }
}
