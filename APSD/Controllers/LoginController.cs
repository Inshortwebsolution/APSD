using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using APSD.Models;
using APSD.Reposetries;

namespace APSD.Controllers
{
    public class LoginController : Controller
    {
       

        ILogin login = new Login();

        // GET: Login
        public ActionResult Index()
        {
            List<Login_Tbl> list = login.GetData();
            return View(list);  
            //return View(db.Login_Tbl.ToList());
        }

        // GET: Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login_Tbl login_Tbl=login.GetAllDataById(id);
            //Login_Tbl login_Tbl = db.Login_Tbl.Find(id);
            if (login_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(login_Tbl);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Record_id,User_Id,Password,Type,LastLoginDate,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Login_Tbl login_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = login.SaveData(login_Tbl);
                
                return RedirectToAction("Index");
            }

            return View(login_Tbl);
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login_Tbl login_Tbl = login.GetAllDataById(id);
            if (login_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(login_Tbl);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Record_id,User_Id,Password,Type,LastLoginDate,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Login_Tbl login_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=login.EditData(login_Tbl);
                
                return RedirectToAction("Index");
            }
            return View(login_Tbl);
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Login_Tbl login_Tbl = login.GetAllDataById(id);
            if (login_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(login_Tbl);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = login.DeleteData(id);
            
            return RedirectToAction("Index");
        }

       
    }
}
