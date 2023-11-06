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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult AllCourse()
        {
            return View();
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
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Ragistration()
        {
            return View();
        }
    }
}