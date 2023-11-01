using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class UploadeVideo: IUploadeVideo
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public List<Gallery_Tbl> GetAll()
        {
            return db.Gallery_Tbl.ToList();
        }

        public bool SaveData(Gallery_Tbl gallery_Tbl)
        {
            bool n=false;
            try
            {
                gallery_Tbl.Crd_Date = DateTime.Now;
                gallery_Tbl.Lmd_Date = DateTime.Now;
                gallery_Tbl.Crd_By = "1";
                gallery_Tbl.Lmd_By = "1";
                gallery_Tbl.IsActive = true;
                gallery_Tbl.IsDeleted = false;   
                db.Gallery_Tbl.Add(gallery_Tbl);
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

        public bool EditData(Gallery_Tbl gallery_Tbl)
        {
            bool n=false;
            try
            {
                //gallery_Tbl.Crd_Date = DateTime.Now;
                //gallery_Tbl.Lmd_Date = DateTime.Now;
                //gallery_Tbl.Crd_By = "1";
                //gallery_Tbl.Lmd_By = "1";
                //gallery_Tbl.IsActive = true;
                //gallery_Tbl.IsDeleted = false;
                db.Entry(gallery_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n=true;
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
        }

        public Gallery_Tbl GetDataByID(int? id)
        {
            return db.Gallery_Tbl.Find(id);
        }

        public int DeleteData(int? id)
        {
            int n = 0;
            try
            {
                Gallery_Tbl gallery_Tbl = db.Gallery_Tbl.Find(id);
                db.Gallery_Tbl.Remove(gallery_Tbl);
                db.SaveChanges();
                n = 1;
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