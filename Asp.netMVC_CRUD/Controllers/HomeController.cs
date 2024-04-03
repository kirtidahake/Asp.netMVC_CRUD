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

        ServiceDataContext db = new ServiceDataContext();


        // GET: Home
        public ActionResult Index()
        {
            var data = db.emp.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if(ModelState.IsValid == true) 
            db.emp.Add(e);
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.CreateMessage = ("<script>alert('Data Saved...')</script>");
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.CreateMessage = ("<script>alert('Data Not Saved...')</script>");
            }
            return View();
        }

        public ActionResult Edit(int id) 
        {
            var row = db.emp.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        //[HttpPost]
        //public ActionResult Edit(Employee e)
        //{ db.emp.
        //    return View(e);
        //}
    }
}