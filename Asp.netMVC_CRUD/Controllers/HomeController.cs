using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.netMVC_CRUD.Models;

namespace Asp.netMVC_CRUD.Controllers
{
    public class HomeController : Controller
    {

        ServiceContext db = new ServiceContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.emp.ToList();
            return View(data);
        }
    }
}