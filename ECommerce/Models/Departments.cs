using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Departments
    {

        [Key]
        public int DepartmentsId { get; set; }

        [Required(ErrorMessage =("O Campo Nome é obrigatorio!"))]
        public string Name { get; set; }
    }
}