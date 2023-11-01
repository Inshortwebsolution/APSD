using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Address : IAddress
    {
        APSD_DatabaseEntities db=new APSD_DatabaseEntities();

        public int DeletedData(int id)
        {
            int n = 0;
            try
            {
                Address_Tbl address_Tbl = db.Address_Tbl.Find(id);
                db.Address_Tbl.Remove(address_Tbl);
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

        public bool EditData(Address_Tbl address_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(address_Tbl).State = EntityState.Modified;
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

        public List<Address_Tbl> GetData()
        {
           return db.Address_Tbl.ToList();
            //throw new NotImplementedException();
        }

        public Address_Tbl GetDataById(int? id)
        {
            return db.Address_Tbl.Find(id);
            //throw new NotImplementedException();
        }

        public bool SaveData(Address_Tbl address_Tbl)
        {
            bool n=false;
            try
            {
                address_Tbl.Crd_Date = DateTime.Now;
                address_Tbl.Crd_By = "1";
                address_Tbl.Lmd_By="1";
                address_Tbl.Lmd_Date = DateTime.Now;
                address_Tbl.IsActive = true;
                address_Tbl.IsDeleted = false;
                db.Address_Tbl.Add(address_Tbl);
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