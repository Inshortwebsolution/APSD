using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Qualification : IQualification
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Qualification_Tbl qualification_Tbl = db.Qualification_Tbl.Find(id);
                db.Qualification_Tbl.Remove(qualification_Tbl);
                db.SaveChanges();
                n = 1;
                return n;
            }
            catch(Exception)
            {
                throw;
            }
            return n;
        }

        public bool EditData(Qualification_Tbl qualification_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(qualification_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
                return n;
            }
            catch (Exception) {
                throw;
            }
            return n;
        }

        public List<Qualification_Tbl> GetAll()
        {
            return db.Qualification_Tbl.ToList();
        }

        public Qualification_Tbl GetDataByID(int? id)
        {
            return db.Qualification_Tbl.Find(id);
        }

        public bool SaveData(Qualification_Tbl qualification_Tbl)
        {
            bool n=false;
            try
            {
                qualification_Tbl.Crd_Date = DateTime.Now;
                qualification_Tbl.Lmd_Date = DateTime.Now;
                qualification_Tbl.Crd_By = "1";
                qualification_Tbl.Lmd_By = "1";
                qualification_Tbl.IsActive = true;
                qualification_Tbl.IsDeleted = false;
                db.Qualification_Tbl.Add(qualification_Tbl);
                db.SaveChanges();
                n = true;
                return n;
            }
            catch (Exception)
            {
                throw;
            }
            return n;
        }
    }
}