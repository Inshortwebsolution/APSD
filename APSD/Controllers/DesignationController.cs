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
    public class DesignationController : Controller
    {
       

        IDesignation designation=new Designation();

        // GET: Designation
        public ActionResult Index()
        {
            List<Designation_Tbl> designation_Tbls = designation.GetData();
            return View(designation_Tbls);
            //return View(db.Designation_Tbl.ToList());
        }

        // GET: Designation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Designation_Tbl designation_Tbl=designation.GetDataById(id);
            //Designation_Tbl designation_Tbl = db.Designation_Tbl.Find(id);
            if (designation_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(designation_Tbl);
        }

        // GET: Designation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Designation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Designation_Id,Des_Tittle,Des_Description,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Designation_Tbl designation_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = designation.SaveData(designation_Tbl);
                
                return RedirectToAction("Index");
            }

            return View(designation_Tbl);
        }

        // GET: Designation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Designation_Tbl designation_Tbl = designation.GetDataById(id);
            if (designation_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(designation_Tbl);
        }

        // POST: Designation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Designation_Id,Des_Tittle,Des_Description,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Designation_Tbl designation_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = designation.EditData(designation_Tbl);
                
                return RedirectToAction("Index");
            }
            return View(designation_Tbl);
        }

        // GET: Designation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Designation_Tbl designation_Tbl = designation.GetDataById(id);
            if (designation_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(designation_Tbl);
        }

        // POST: Designation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = designation.DelatedData(id);
            
            return RedirectToAction("Index");
        }

        
    }
}
