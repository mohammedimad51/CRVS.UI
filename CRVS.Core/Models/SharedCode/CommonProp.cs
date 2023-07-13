using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRVS.Core.Models.SharedCode
{
    public class CommonProp
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public enum Genders
        { ذكر,انثى,خنثى }

        public enum NationalIdFors 
        { الاب , الام}
        public enum DocumentTypes
        {

            هوية_الاحوال_المدنية, البطاقة_الوطنية_الموحدة, جواز_السفر

        }
        public enum PlaceOfBirths
        { بيت ,مستشفى_او_مركز }
        public enum BirthOccurredBys
        { ممرضة,طبيب,اخرى,قابلة }
        public enum NumberOfBirths
        { مفردة ,توام,اكثر  }
        public enum BirthTypes
        { طبيعية , قيصرية}

    }
}
