using APSD.Models;
using APSD.Reposetries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace APSD.Controllers
{
    public class HomeController : Controller
    {
        IHome home = new Home();
        IEvent Event = new Event();
        public ActionResult Index()
        {
            List<Event_Tbl> event1= Event.GetData();
            return View(event1);
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult AllCourse()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            List<Gallery_Tbl> gallery = home.getVideos();
            return View(gallery);
        }

        public ActionResult AdminPannel()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login_Tbl Model)
        {
            if (ModelState.IsValid)
            {
                bool res = home.LoginData(Model);

                return RedirectToAction("Index", "Login");
            }

            return View();
            
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Login_Tbl Model)
        {
            if (ModelState.IsValid) 
            {
                bool res = home.SignupData(Model);
            }
            return RedirectToAction("Login");
           
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}