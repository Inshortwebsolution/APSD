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
    public class QualificationController : Controller
    {
        IQualification _qualification = new Qualification();

        // GET: Qualificationl
        public ActionResult Index()
        {
            List<Qualification_Tbl> list = _qualification.GetAll();
            return View(list);
        }

        // GET: Qualificationl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualification_Tbl qualification_Tbl = _qualification.GetDataByID(id);
            if (qualification_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(qualification_Tbl);
        }

        // GET: Qualificationl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Qualificationl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Qualfication_Id,Education_Id,Board,Passing_Year,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Qualification_Tbl qualification_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _qualification.SaveData(qualification_Tbl);
                return RedirectToAction("Index");
            }

            return View(qualification_Tbl);
        }

        // GET: Qualificationl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualification_Tbl qualification_Tbl = _qualification.GetDataByID(id);
            if (qualification_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(qualification_Tbl);
        }

        // POST: Qualificationl/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Qualfication_Id,Education_Id,Board,Passing_Year,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Qualification_Tbl qualification_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=_qualification.EditData(qualification_Tbl);
                return RedirectToAction("Index");
            }
            return View(qualification_Tbl);
        }

        // GET: Qualificationl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Qualification_Tbl qualification_Tbl = _qualification.GetDataByID(id);
            if (qualification_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(qualification_Tbl);
        }

        // POST: Qualificationl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = _qualification.DeleteData(id);
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
