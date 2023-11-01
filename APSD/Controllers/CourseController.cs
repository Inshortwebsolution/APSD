﻿using System;
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
    public class CourseController : Controller
    {
        ICourse _course = new Course();

        // GET: Course
        public ActionResult Index()
        {
            List<Course_Tbl> list = _course.GetAll();
            return View(list);
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Tbl course_Tbl = _course.GetDataByID(id);
            if (course_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(course_Tbl);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Course_Id,Course_Name,Course_Description,Course_Duration_IN_Dates,Course_Image,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Course_Tbl course_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _course.SaveData(course_Tbl);
            
                return RedirectToAction("Index");
            }

            return View(course_Tbl);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Tbl course_Tbl = _course.GetDataByID(id);
            if (course_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(course_Tbl);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Course_Id,Course_Name,Course_Description,Course_Duration_IN_Dates,Course_Image,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Course_Tbl course_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res= _course.EditData(course_Tbl);
                return RedirectToAction("Index");
            }
            return View(course_Tbl);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course_Tbl course_Tbl = _course.GetDataByID(id);
            if (course_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(course_Tbl);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            int res = _course.DeleteData(id);
            
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
