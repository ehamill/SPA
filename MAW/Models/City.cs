using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MAW.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string ServerId { get; set; }
        [Required]
        public string UserId { get; set; }
        public string CityName { get; set; }
        
    }
}
