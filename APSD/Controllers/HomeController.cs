using APSD.Models;
using APSD.Reposetries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace APSD.Controllers
{
    public class HomeController : Controller
    {
        IHome home = new Home();
        IEvent Event = new Event();
        public ActionResult Index()
        {
            List<Course_Tbl> course_Tbls = home.getcoures();
            List<Event_Tbl> event_Tbls = home.getEvent();
            List<FeedBack_Tbl> feedback_Tbls = home.getFeedback();
            Tuple<List<Course_Tbl>, List<Event_Tbl>, List<FeedBack_Tbl>> tpl = new Tuple<List<Course_Tbl>, List<Event_Tbl>, List<FeedBack_Tbl>>(course_Tbls, event_Tbls, feedback_Tbls);

            return View(tpl);
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult AllCourse()
        {
            List<Course_Tbl> courses = home.getcoures();
            return View(courses);
        }
        public ActionResult AdminPannel()
        {
            return View();
        }

        public ActionResult OurPlacement()
        {
            return View();
        }
        
        public ActionResult StudentRegistration()
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
                Login_Tbl res = home.LoginData(Model);

                if (res.Type == "ADMIN")
                {
                    return RedirectToAction("Desboard", "Admin");

                }
                else if (res.Type == "USER")
                {
                    return RedirectToAction("USER", "Home");

                }

                else if (res== null)
                {
                    MessageBox.Show("Invalid UserName And Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
        public ActionResult USER()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}