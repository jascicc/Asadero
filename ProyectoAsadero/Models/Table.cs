using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAsadero.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }

        [Required]
        [Display(Name = "Mesa")]
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}