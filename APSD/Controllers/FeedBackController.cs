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
    public class FeedBackController : Controller
    {
        IFeedBack _feedback = new FeedBack();

        // GET: FeedBack
        public ActionResult Index()
        {
            List<FeedBack_Tbl> list = _feedback.GetAll();
            return View(list);
        }

        // GET: FeedBack/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBack_Tbl feedBack_Tbl = _feedback.GetDataByID(id);
            if (feedBack_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(feedBack_Tbl);
        }

        // GET: FeedBack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FeedBack/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Feedback_Id,User_ID,Description,Rating,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] FeedBack_Tbl feedBack_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _feedback.SaveData(feedBack_Tbl);
                return RedirectToAction("Index");
            }

            return View(feedBack_Tbl);
        }

        // GET: FeedBack/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBack_Tbl feedBack_Tbl = _feedback.GetDataByID(id);
            if (feedBack_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(feedBack_Tbl);
        }

        // POST: FeedBack/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Feedback_Id,User_ID,Description,Rating,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] FeedBack_Tbl feedBack_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=_feedback.EditData(feedBack_Tbl);
                return RedirectToAction("Index");
            }
            return View(feedBack_Tbl);
        }

        // GET: FeedBack/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedBack_Tbl feedBack_Tbl = _feedback.GetDataByID(id);
            if (feedBack_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(feedBack_Tbl);
        }

        // POST: FeedBack/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res=_feedback.DeleteData(id);
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
