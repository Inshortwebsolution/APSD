using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Employee : IEmployee
    {
        APSD_DatabaseEntities db=new APSD_DatabaseEntities();

        public int DeletedData(int id)
        {
            int n = 0;
            try
            {
                Employee_Table employee_Table = db.Employee_Table.Find(id);
                db.Employee_Table.Remove(employee_Table);
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

        public bool EditData(Employee_Table employee_Table)
        {
            bool n = false;
            try
            {
                db.Entry(employee_Table).State = EntityState.Modified;
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

        public List<Employee_Table> GetData()
        {
            return db.Employee_Table.ToList();
            //throw new NotImplementedException();
        }

        public Employee_Table GetDataById(int? id)
        {
            return db.Employee_Table.Find(id);
            //throw new NotImplementedException();
        }

        public bool SaveData(Employee_Table employee_Table)
        {
            bool n=false;
            try
            {
                employee_Table.Crd_Date = DateTime.Now;
                employee_Table.Crd_By = "1";
                employee_Table.Lmd_Date = DateTime.Now;
                employee_Table.Lmd_By = "1";
                employee_Table.IsActive = true;
                employee_Table.IsDeleted = false;
                db.Employee_Table.Add(employee_Table);
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