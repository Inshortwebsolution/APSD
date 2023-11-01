using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Student : IStudent
    {
        private APSD_DatabaseEntities db = new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Student_Tbl student_Tbl = db.Student_Tbl.Find(id);
                db.Student_Tbl.Remove(student_Tbl);
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

        public bool EditData(Student_Tbl student_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(student_Tbl).State = EntityState.Modified;
                db.SaveChanges();
                n = true;
                return n;
            }
            catch(Exception)
            {
                throw;
            }
            return n;
        }

        public List<Student_Tbl> GetAll()
        {
            return db.Student_Tbl.ToList();
        }

        public Student_Tbl GetDataByID(int? id)
        {
            return db.Student_Tbl.Find(id);
        }

        public bool SaveData(Student_Tbl student_Tbl)
        {
            bool n=false;
            try
            {
                student_Tbl.Crd_Date = DateTime.Now;
                student_Tbl.Lmd_Date = DateTime.Now;
                student_Tbl.Crd_By = "1";
                student_Tbl.Lmd_By = "1";
                student_Tbl.IsActive = true;
                student_Tbl.IsDeleted = false;
                db.Student_Tbl.Add(student_Tbl);
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