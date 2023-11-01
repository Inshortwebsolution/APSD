using APSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APSD.Reposetries
{
    public class Event : IEvent
    {
        APSD_DatabaseEntities db=new APSD_DatabaseEntities();

        public int DeleteData(int id)
        {
            int n = 0;
            try
            {
                Event_Tbl event_Tbl1 = db.Event_Tbl.Find(id);
                db.Event_Tbl.Remove(event_Tbl1);
                db.SaveChanges();
                return n;
            }
            catch (Exception)
            {

                throw;
            }
            return n;
        }

        public bool EditData(Event_Tbl event_Tbl)
        {
            bool n=false;
            try
            {
                db.Entry(event_Tbl).State = EntityState.Modified;
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

        public List<Event_Tbl> GetData()
        {
            return db.Event_Tbl.ToList();
        }

        public Event_Tbl GetDataById(int? id)
        {
            return db.Event_Tbl.Find(id);
        }

        public bool SaveData(Event_Tbl event_Tbl)
        {
            bool n=false;
            try
            {
                event_Tbl.Lmd_Date = DateTime.Now;
                event_Tbl.Crd_By = "1";
                event_Tbl.Lmd_By = "1";
                event_Tbl.Crd_Date = DateTime.Now;
                event_Tbl.IsActive = true;
                event_Tbl.ISDeleted = false;
                db.Event_Tbl.Add(event_Tbl);
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



    }
}