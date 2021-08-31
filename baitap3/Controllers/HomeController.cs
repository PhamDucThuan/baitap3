using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap3.Controllers
{
    public class HomeController : Controller
    {
        giaiPhuongTrinh gpt = new giaiPhuongTrinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult giaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult giaiPTB1(double heSoA, double heSoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(heSoA, heSoB);
            ViewBag.nghiemPT = x;
            return View();
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