using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using APSD.Models;
using APSD.Reposetries;

namespace APSD.Controllers
{
    public class ImagesController : Controller
    {
        IUploadeImage _imageupload = new UploadeImage();


        // GET: Images
        public ActionResult Index()
        {
            List<Gallery_Tbl> list = _imageupload.GetAll();
            return View(list);
        }

        // GET: Images/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl = _imageupload.GetDataByID(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GalleryItemId,Gallery_Title,Description,File_Path,File_Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Gallery_Tbl gallery_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=_imageupload.SaveData(gallery_Tbl);
                return RedirectToAction("Index");
            }

            return View(gallery_Tbl);
        }

        // GET: Images/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl = _imageupload.GetDataByID(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // POST: Images/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GalleryItemId,Gallery_Title,Description,File_Path,File_Type,Crd_Date,Crd_By,Lmd_Date,Lmd_By,IsActive,IsDeleted")] Gallery_Tbl gallery_Tbl)
        {
            if (ModelState.IsValid)
            {
                bool res=_imageupload.EditData(gallery_Tbl);
                return RedirectToAction("Index");
            }
            return View(gallery_Tbl);
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery_Tbl gallery_Tbl =_imageupload.GetDataByID(id);
            if (gallery_Tbl == null)
            {
                return HttpNotFound();
            }
            return View(gallery_Tbl);
        }

        // POST: Images/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            int res=_imageupload.DeleteData(id);
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
            return Json(finalpath,JsonRequestBehavior.AllowGet);
        }
    }
}
