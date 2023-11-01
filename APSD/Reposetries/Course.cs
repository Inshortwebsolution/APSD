using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Course : ICourse
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int? id)
        {
            int n = 0;
            try
            {
                Course_Tbl course_Tbl = db.Course_Tbl.Find(id);
                db.Course_Tbl.Remove(course_Tbl);
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

        public bool EditData(Course_Tbl course_Tbl)
        {
            bool n = false;
            try
            {
                db.Entry(course_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n= true;
                return n;   
            }
            catch (Exception)
            {
                throw;
            }
            return n;
        }

        public List<Course_Tbl> GetAll()
        {
            return db.Course_Tbl.ToList();

            //throw new NotImplementedException();
        }

        public Course_Tbl GetDataByID(int? id)
        {
            return db.Course_Tbl.Find(id);
        }

        public bool SaveData(Course_Tbl course_Tbl)
        {
            bool n = false;
            try
            {
                course_Tbl.Crd_Date = DateTime.Now;
                course_Tbl.Lmd_Date = DateTime.Now;
                course_Tbl.Crd_By = "1";
                course_Tbl.Lmd_By = "1";
                course_Tbl.IsActive = true;
                course_Tbl.IsDeleted = false;
                db.Course_Tbl.Add(course_Tbl);
                db.SaveChanges();
                n = true;
                return n;
            }
            catch(Exception) {
                throw;
            }
            return n;

        }
    }
}