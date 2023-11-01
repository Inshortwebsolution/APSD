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
    public class AddressController : Controller
    {
        

        IAddress address = new Address();

        // GET: Address
        public ActionResult Index()
        {
            List<Address_Tbl> list = address.GetData();
            return View(list);
            
        }

        // GET: Address/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address_Tbl address_Tbl = address.GetDataById(id);
           
            if (address_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(address_Tbl);
        }

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Address_Id,Country_Id,State_Id,District_Id,PinCode,Landmark,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Address_Tbl address_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res = address.SaveData(address_Tbl);
                
                return RedirectToAction("Index");
            }

            return View(address_Tbl);
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address_Tbl address_Tbl = address.GetDataById(id);
            if (address_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(address_Tbl);
        }

        // POST: Address/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Address_Id,Country_Id,State_Id,District_Id,PinCode,Landmark,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Address_Tbl address_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=address.EditData(address_Tbl);
                
                return RedirectToAction("Index");
            }
            return View(address_Tbl);
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Address_Tbl address_Tbl = address.GetDataById(id);
            if (address_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(address_Tbl);
        }

        // POST: Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = address.DeletedData(id);
            
            return RedirectToAction("Index");
        }

       
    }
}
