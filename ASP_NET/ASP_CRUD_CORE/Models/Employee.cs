using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace ASP_CRUD_CORE.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public string CITY { get; set; }
        [Required]
        public string AGE { get; set; }
        
    }
}
