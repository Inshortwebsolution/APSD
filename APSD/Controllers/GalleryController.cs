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
    public class GalleryController : Controller
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();
        IUploadeVideo _videoupload=new UploadeVideo();
        // GET: Gallery

        public ActionResult Index()
        {
            List<Gallery_Tbl> list = _videoupload.GetAll();
            return View(list);
        }

        // POST: Gallery_Tbl/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Gallery_Title,Description,File_Path,File_Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Gallery_Tbl gallery_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _videoupload.SaveData(gallery_Tbl);

                return RedirectToAction("Index");
            }

            return View(gallery_Tbl);
        }

        // GET: Gallery/Details/5
        public ActionResult Details(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl = db.Gallery_Tbl.Find(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // GET: Gallery/Create
        public ActionResult Create()
        {
            return View();
        }

      
        // GET: Gallery/Edit/5
        public ActionResult Edit(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl = db.Gallery_Tbl.Find(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // POST: Gallery/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Gallery_Title,Description,File_Path,File_Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted,GalleryItemId")] Gallery_Tbl gallery_Tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gallery_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gallery_Tbl);
        }

        // GET: Gallery/Delete/5
        public ActionResult Delete(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl = db.Gallery_Tbl.Find(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // POST: Gallery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(bool id)
        {
            Gallery_Tbl gallery_Tbl = db.Gallery_Tbl.Find(id);
            db.Gallery_Tbl.Remove(gallery_Tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
