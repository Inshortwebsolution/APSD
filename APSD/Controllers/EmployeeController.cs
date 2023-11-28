using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using APSD.Models;
using APSD.Reposetries;

namespace APSD.Controllers
{
    public class EmployeeController : Controller
    {
      
        IEmployee employee=new Employee();

        // GET: Employee
        public ActionResult Index()
        {
            List<Employee_Table> list=employee.GetData();
            return View(list);
            //return View(db.Employee_Table.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Table employee_Table = employee.GetDataById(id);
            //Employee_Table employee_Table = db.Employee_Table.Find(id);
            if (employee_Table == null)
            {
                return HttpNotFound();
            }
            return View(employee_Table);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Employee_Id,Name,Email,Mobile,Gender,Designation_Id,Sallery,Address_Id,Profile_Img,Qualification_Id,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Employee_Table employee_Table)
        {
            if (ModelState.IsValid)
            {
                bool res = employee.SaveData(employee_Table);
                
                return RedirectToAction("Index");
            }

            return View(employee_Table);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Table employee_Table = employee.GetDataById(id);
            if (employee_Table == null)
            {
                return HttpNotFound();
            }
            return View(employee_Table);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Employee_Id,Name,Email,Mobile,Gender,Designation_Id,Sallery,Address_Id,Profile_Img,Qualification_Id,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Employee_Table employee_Table)
        {
            if (ModelState.IsValid)
            {
                bool res=employee.EditData(employee_Table);
               
                return RedirectToAction("Index");
            }
            return View(employee_Table);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Table employee_Table = employee.GetDataById(id);
            if (employee_Table == null)
            {
                return HttpNotFound();
            }
            return View(employee_Table);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = employee.DeletedData(id);
            
            return RedirectToAction("Index");
        }

        public JsonResult Upload()
        {
            string finalpath = "";
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                                                            //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;

                string path = Path.Combine(Server.MapPath("/UploadFile"), file.FileName);
                string searchTerm = "\\UploadFile\\";

                int startIndex = path.IndexOf(searchTerm);

                if (startIndex >= 0)
                {
                    finalpath = path.Substring(startIndex).Replace('\\', '/'); // Extract from the startIndex to the end of the string

                }
                //To save file, use SaveAs method
                file.SaveAs(path); //File will be saved in application root
            }
            return Json(finalpath, JsonRequestBehavior.AllowGet);
        }
    }
}
