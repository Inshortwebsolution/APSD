using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Document : IDocument
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Document_Tbl document_Tbl = db.Document_Tbl.Find(id);
                db.Document_Tbl.Remove(document_Tbl);
                db.SaveChanges();
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }

        public bool EditData(Document_Tbl document_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(document_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public List<Document_Tbl> GetData()
        {
            return db.Document_Tbl.ToList();
        }

        public Document_Tbl GetDataById(int? id)
        {
           return db.Document_Tbl.Find(id);
        }

        public bool Saveadata(Document_Tbl document_Tbl)
        {
            bool n = false;
            try
            {
                document_Tbl.Crd_Date = DateTime.Now;
                document_Tbl.Crd_By = "1";
                document_Tbl.Lmd_By = "1";
                document_Tbl.Lmd_Date = DateTime.Now;
                document_Tbl.IsActive = true;
                document_Tbl.ISDeleted = false;
                db.Document_Tbl.Add(document_Tbl);
                db.SaveChanges();
                n = true;
                return n;
                
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}