using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Education : IEducation
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Education_Tbl education_Tbl = db.Education_Tbl.Find(id);
                db.Education_Tbl.Remove(education_Tbl);
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

        public bool EditData(Education_Tbl education_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(education_Tbl).State = EntityState.Modified;
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

        public List<Education_Tbl> GetAll()
        {
            return db.Education_Tbl.ToList();
        }

        public Education_Tbl GetDataByID(int? id)
        {
            return db.Education_Tbl.Find(id);
        }

        public bool SaveData(Education_Tbl education_Tbl)
        {
            bool n=false;
            try
            {
                education_Tbl.Crd_Date = DateTime.Now;
                education_Tbl.Lmd_Date = DateTime.Now;
                education_Tbl.Crd_By = "1";
                education_Tbl.Lmd_By = "1";
                education_Tbl.IsActive = true;
                education_Tbl.IsDeleted = false;
                db.Education_Tbl.Add(education_Tbl);
                db.SaveChanges();
                n= true;
                return n;
            }
            catch(Exception)
            {
                throw;
            }
            return n;
        }
    }
}