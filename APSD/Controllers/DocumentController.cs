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
    public class DocumentController : Controller
    {
        IDocument Doc=new Document();
        ICourse Course=new Course();
        // GET: Document
        public ActionResult Index()
        {
            List<Document_Tbl> list = Doc.GetData();
            return View(list);
        }

        // GET: Document/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Tbl document_Tbl = Doc.GetDataById(id);
            if (document_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(document_Tbl);
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DocId,RefId,file_path")] Document_Tbl document_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res= Doc.Saveadata(document_Tbl);
                return RedirectToAction("Index");
            }

            return View(document_Tbl);
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Tbl document_Tbl = Doc.GetDataById(id);
            if (document_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(document_Tbl);
        }

        // POST: Document/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DocId,RefId,file_path,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,ISDeleted")] Document_Tbl document_Tbl)
        {
            if (ModelState.IsValid)
            {
               bool res = Doc.EditData(document_Tbl);
                return RedirectToAction("Index");
            }
            return View(document_Tbl);
        }

        // GET: Document/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Document_Tbl document_Tbl = Doc.GetDataById(id);
            if (document_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(document_Tbl);
        }

        // POST: Document/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res = Doc.DeleteData(id);
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
