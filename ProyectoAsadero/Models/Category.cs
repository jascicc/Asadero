using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAsadero.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "Nombre categoria")]
        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}