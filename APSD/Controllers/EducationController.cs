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
    public class EducationController : Controller
    {
        IEducation _education=new Education();

        // GET: Education
        public ActionResult Index()
        {
            List<Education_Tbl> list = _education.GetAll();
            return View(list);
        }

        // GET: Education/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education_Tbl education_Tbl = _education.GetDataByID(id);
            if (education_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(education_Tbl);
        }

        // GET: Education/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Education/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Education_Id,Title,Description,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Education_Tbl education_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _education.SaveData(education_Tbl);
                
                return RedirectToAction("Index");
            }

            return View(education_Tbl);
        }

        // GET: Education/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education_Tbl education_Tbl = _education.GetDataByID(id);
            if (education_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(education_Tbl);
        }

        // POST: Education/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Education_Id,Title,Description,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Education_Tbl education_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _education.EditData(education_Tbl);
                
                return RedirectToAction("Index");
            }
            return View(education_Tbl);
        }

        // GET: Education/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Education_Tbl education_Tbl = _education.GetDataByID(id);
            if (education_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(education_Tbl);
        }

        // POST: Education/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = _education.DeleteData(id);
            
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
