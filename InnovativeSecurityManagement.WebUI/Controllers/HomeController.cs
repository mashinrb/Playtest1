using InnovativeSecurityManagement.Contracts.Repositories;
using InnovativeSecurityManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InnovativeSecurityManagement.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryBase<Employee> employees;
        public HomeController(IRepositoryBase<Employee> employees)
        {
            this.employees = employees;
        }
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}