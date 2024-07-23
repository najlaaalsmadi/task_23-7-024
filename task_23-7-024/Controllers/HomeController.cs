using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task_23_7_024.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult ReceiveData(int id, string name, string gender, string[] coures, string cities)
        {
            
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Gender = gender;
            ViewBag.Coures = string.Join(" , ", coures); // تحويل مصفوفة الدورات إلى سلسلة نصية
            ViewBag.Cities = cities;
            return View("DisplayData"); 
        }
        public ActionResult DisplayData()
        {
            ViewBag.Message = "Your DisplayData page.";

            return View();
        }
    }

}
