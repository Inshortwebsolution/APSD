using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Designation : IDesignation
    {
        APSD_DatabaseEntities db=new APSD_DatabaseEntities();

        public int DelatedData(int id)
        {
            int n = 0;
            try
            {
                Designation_Tbl designation_Tbl = db.Designation_Tbl.Find(id);
                db.Designation_Tbl.Remove(designation_Tbl);
                db.SaveChanges();
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
            //throw new NotImplementedException();
        }

        public bool EditData(Designation_Tbl designation_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(designation_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
            //throw new NotImplementedException();
        }

        public List<Designation_Tbl> GetData()
        {
            return db.Designation_Tbl.ToList();
            //throw new NotImplementedException();
        }

        public Designation_Tbl GetDataById(int? id)
        {
            return db.Designation_Tbl.Find(id);
            //throw new NotImplementedException();
        }

        public bool SaveData(Designation_Tbl designation_Tbl)
        {
            bool n=false;
            try
            {
                designation_Tbl.Crd_Date = DateTime.Now;
                designation_Tbl.Crd_By = "1";
                designation_Tbl.Lmd_Date = DateTime.Now;
                designation_Tbl.Lmd_By = "1";
                designation_Tbl.IsActive = true;
                designation_Tbl.IsDeleted = false;
                db.Designation_Tbl.Add(designation_Tbl);
                db.SaveChanges();
                n = true;
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
            //throw new NotImplementedException();
        }
    }
}