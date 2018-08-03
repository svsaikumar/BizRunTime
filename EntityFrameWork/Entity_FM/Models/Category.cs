using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entity_FM.Models
{
    [Table("tblCategories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column]
        public string CategoryName { get; set; }
    }
}