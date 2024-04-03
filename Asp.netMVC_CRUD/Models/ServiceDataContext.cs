using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Asp.netMVC_CRUD.Models
{
    public class ServiceDataContext : DbContext
    {
        public DbSet<Employee> emp { get; set; }
    }
}