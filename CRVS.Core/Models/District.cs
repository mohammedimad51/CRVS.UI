using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class District
    {
        public int DistrictId { get; set; }
        public string? DistrictName { get; set;}
        public int GovernorateId { get; set; }
        public int DohId { get; set; }
            
    }
}
