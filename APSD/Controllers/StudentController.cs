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
    public class StudentController : Controller
    {
        IStudent _student=new Student();

        // GET: Student
        public ActionResult Index()
        {
            List<Student_Tbl> list = _student.GetAll();
            return View(list);
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Tbl student_Tbl = _student.GetDataByID(id);
            if (student_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_Tbl);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Student_Id,Enrollment_Id,Student_Name,Email,Mobile,College,Branch,Year,Aadhaar,Technologies_Id,Registration_Fee,Course_Id,Program,Address_ID,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Student_Tbl student_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _student.SaveData(student_Tbl);
                return RedirectToAction("Index");
            }

            return View(student_Tbl);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Tbl student_Tbl = _student.GetDataByID(id);
            if (student_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_Tbl);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Student_Id,Enrollment_Id,Student_Name,Email,Mobile,College,Branch,Year,Aadhaar,Technologies_Id,Registration_Fee,Course_Id,Program,Address_ID,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Student_Tbl student_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res= _student.EditData(student_Tbl);
                return RedirectToAction("Index");
            }
            return View(student_Tbl);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_Tbl student_Tbl = _student.GetDataByID(id);
            if (student_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_Tbl);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = _student.DeleteData(id);
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
