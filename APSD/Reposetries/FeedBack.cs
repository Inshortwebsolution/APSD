using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class FeedBack : IFeedBack
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                FeedBack_Tbl feedBack_Tbl = db.FeedBack_Tbl.Find(id);
                db.FeedBack_Tbl.Remove(feedBack_Tbl);
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

        public bool EditData(FeedBack_Tbl feedBack_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(feedBack_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
                return n;
            }
            catch (Exception) { 
            }
            return n;   
        }

        public List<FeedBack_Tbl> GetAll()
        {
            return db.FeedBack_Tbl.ToList();
        }

        public FeedBack_Tbl GetDataByID(int? id)
        {
            return db.FeedBack_Tbl.Find(id);
        }

        public bool SaveData(FeedBack_Tbl feedBack_Tbl)
        {
            bool n=false;
            try
            {
                feedBack_Tbl.Crd_Date = DateTime.Now;
                feedBack_Tbl.Lmd_Date = DateTime.Now;
                feedBack_Tbl.Crd_By = "1";
                feedBack_Tbl.Lmd_By = "1";
                feedBack_Tbl.IsActive = true;
                feedBack_Tbl.IsDeleted = false;
                db.FeedBack_Tbl.Add(feedBack_Tbl);
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