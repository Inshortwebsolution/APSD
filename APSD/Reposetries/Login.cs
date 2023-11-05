using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Login : ILogin
    {
        APSD_DatabaseEntities db=new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Login_Tbl login_Tbl = db.Login_Tbl.Find(id);
                db.Login_Tbl.Remove(login_Tbl);
                db.SaveChanges();
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
            //throw new NotImplementedException();
        }

        public bool EditData(Login_Tbl login_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(login_Tbl).State = EntityState.Modified;
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

        public Login_Tbl GetAllDataById(int? id)
        {
            return db.Login_Tbl.Find(id);
        }

        public List<Login_Tbl> GetData()
        {
            return db.Login_Tbl.ToList();
            //throw new NotImplementedException();
        }

        public bool SaveData(Login_Tbl login_Tbl)
        {
            bool n=false;
            try
            {
                login_Tbl.Type = login_Tbl.Type;
                login_Tbl.LastLoginDate = DateTime.Now;
                login_Tbl.Crd_Date = DateTime.Now;
                login_Tbl.Crd_By = "1";
                login_Tbl.Lmd_Date = DateTime.Now;
                login_Tbl.Lmd_By = "1";
                login_Tbl.IsActive = true;
                login_Tbl.IsDeleted = false;
                db.Login_Tbl.Add(login_Tbl);
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