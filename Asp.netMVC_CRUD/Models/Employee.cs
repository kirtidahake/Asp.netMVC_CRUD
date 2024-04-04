using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Asp.netMVC_CRUD.Models
{
    public class Employee
    {
        [Key] //This is validation
        [Required]
        [DisplayName("EMPLOYEE ID")]
        public int Id { get; set; }


        [Required]
        [DisplayName("EMPLOYEE NAME")]
        public string Name { get; set; }

        [Required]
        [DisplayName("EMPLOYEE DEPARTMENT")]
        public string Department { get; set; }

        [Required]
        [DisplayName("EMPLOYEE SALARY")]
        public int Salary { get; set; }

        [Required]
        [DisplayName("EMPLOYEE PHONE NUMBER")]
        [RegularExpression(@"^\d{1,10}$", ErrorMessage = "phone number must be between 1 and 10 digits.")]
        public string PhoneNumber { get; set; }
    }
}