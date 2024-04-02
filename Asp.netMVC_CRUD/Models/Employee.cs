﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Asp.netMVC_CRUD.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DisplayName("EMP ID")]
        public int Id { get; set; }


        [Required]
        [DisplayName("EMP NAME")]
        public string Name { get; set; }

        [Required]
        [DisplayName("EMP DEPARTMENT")]
        public string Department { get; set; }

        [Required]
        [DisplayName("EMP SALARY")]
        public int Salary { get; set; }
    }
}