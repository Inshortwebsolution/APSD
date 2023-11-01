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
    public class EventController : Controller
    {
        IEvent _event=new Event();

        // GET: Event
        public ActionResult Index()
        {
            List<Event_Tbl> list = _event.GetData();
            return View(list);
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Tbl event_Tbl = _event.GetDataById(id);
            if (event_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(event_Tbl);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Event_Id,Event_Tittle,Event_Description,Join_Date,Exp_Date,Start_Date,End_Date,Fee,Total_Sheats,Lectures,Image,Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,ISDeleted")] Event_Tbl event_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = _event.SaveData(event_Tbl);
                return RedirectToAction("Index");
            }

            return View(event_Tbl);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Tbl event_Tbl = _event.GetDataById(id);
            if (event_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(event_Tbl);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Event_Id,Event_Tittle,Event_Description,Join_Date,Exp_Date,Start_Date,End_Date,Fee,Total_Sheats,Lectures,Image,Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,ISDeleted")] Event_Tbl event_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res= _event.EditData(event_Tbl);
                return RedirectToAction("Index");
            }
            return View(event_Tbl);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event_Tbl event_Tbl = _event.GetDataById(id);
            if (event_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(event_Tbl);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = _event.DeleteData(id);
            //Event_Tbl Event = db.Event_Tbl.Find(Event_Id);
            return RedirectToAction("Index");
        }

        
    }
}
