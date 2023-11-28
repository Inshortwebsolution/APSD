using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Placement : IPlacement
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeletedData(int id)
        {
            int n = 0;
            try
            {
                Placement_Tbl placement_Tbl = db.Placement_Tbl.Find(id);
                db.Placement_Tbl.Remove(placement_Tbl);
                db.SaveChanges();
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
        }

        public bool EditData(Placement_Tbl placement_Tbl)
        {
            bool n = false;
            try
            {
                db.Entry(placement_Tbl).State = EntityState.Modified;
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

        public List<Placement_Tbl> GetData()
        {
            return db.Placement_Tbl.ToList();
        }

        

        public List<Placement_Tbl> getPlacement()
        {
            return db.Placement_Tbl.ToList();
        }

        public bool SaveData(Placement_Tbl placement_Tbl)
        {
            bool n = false;
            try
            {
                placement_Tbl.Crd_Date = DateTime.Now;
                placement_Tbl.Crd_By = "1";
                placement_Tbl.Lmd_By = "1";
                placement_Tbl.Lmd_Date = DateTime.Now;
                placement_Tbl.IsActive = true;
                placement_Tbl.ISDeleted = false;
                db.Placement_Tbl.Add(placement_Tbl);
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

        Placement_Tbl IPlacement.GetDataById(int? id)
        {
            return db.Placement_Tbl.Find(id);
        }
    }
}