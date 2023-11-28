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
    public class PlacementController : Controller
    {
        
        IPlacement placement=new Placement();
        IStudent student=new Student();
        public ActionResult OurPlacement()
        {
            List<Placement_Tbl> placement_Tbls = placement.getPlacement();
            List<Student_Tbl> student_Tbls = student.GetAll();

            Tuple<List<Placement_Tbl>,List<Student_Tbl>> tpl = new Tuple<List<Placement_Tbl>,List<Student_Tbl>>(placement_Tbls, student_Tbls);

            return View(tpl);
        }
        // GET: Placement
        public ActionResult Index()
        {
            List<Placement_Tbl> list = placement.GetData();
            return View(list);
        }

        // GET: Placement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Placement_Tbl placement_TBl = placement.GetDataById(id);

            if (placement_TBl == null)
            {
                return HttpNotFound();
            }
            return View(placement_TBl);
        }

        // GET: Placement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Placement/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pacemnet_ID,Student_ID,Company_Name,Join_Date,Position,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,ISDeleted")] Placement_Tbl placement_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = placement.SaveData(placement_Tbl);
                return RedirectToAction("Index");
            }

            return View(placement_Tbl);
        }

    // GET: Placement/Edit/5
    public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Placement_Tbl placement_Tbl = placement.GetDataById(id);
            if (placement_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(placement_Tbl);
        }
        
// POST: Placement/Edit/5
// To protect from overposting attacks, enable the specific properties you want to bind to, for 
// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pacemnet_ID,Student_ID,Company_Name,Join_Date,Position,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,ISDeleted")] Placement_Tbl placement_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = placement.EditData(placement_Tbl);
                return RedirectToAction("Index");
            }
            return View(placement_Tbl);
        }
        
    // GET: Placement/Delete/5
    public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Placement_Tbl placement_Tbl = placement.GetDataById(id);
            if (placement_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(placement_Tbl);
        }
        
// POST: Placement/Delete/5
[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = placement.DeletedData(id);
            return RedirectToAction("Index");
        }


    }
}
