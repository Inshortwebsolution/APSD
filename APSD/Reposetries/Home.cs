using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;

namespace APSD.Reposetries
{
    public class Home : IHome
    {
        APSD_DatabaseEntities context = new APSD_DatabaseEntities();

        public List<Course_Tbl> getcoures()

        public List<Gallery_Tbl> getVideos()
        {
            return context.Gallery_Tbl.ToList();
        }

        public bool LoginData(Login_Tbl model)
        {
            return context.Course_Tbl.ToList();
        }

        public List<Event_Tbl> getEvent()
        {
            return context.Event_Tbl.ToList();
        }

        public List<FeedBack_Tbl> getFeedback()
        {
            return context.FeedBack_Tbl.ToList();
        }

        public Login_Tbl LoginData(Login_Tbl model)
        {
            Login_Tbl data = new Login_Tbl();
            try
            {

                model.LastLoginDate = DateTime.Now;
                model.Crd_Date = DateTime.Now;
                model.Crd_By = "1";
                model.Lmd_Date = DateTime.Now;
                model.Lmd_By = "1";
                model.IsActive = true;
                model.IsDeleted = false;
                data = context.Login_Tbl.Where(x => x.User_Id == model.User_Id && x.Password == model.Password).FirstOrDefault();
                if (data!=null)
                {
                    FormsAuthentication.SetAuthCookie(model.User_Id.ToString(), false);
                    return data;
                }
                else
                {
                    MessageBox.Show("Invalid UserName And Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return data;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return data;
            //throw new NotImplementedException();
        }

        

        public bool SignupData(Login_Tbl model)
        {
            bool n= false;
            try
            {
                model.Type = model.Type;
                model.LastLoginDate = DateTime.Now;
                model.Crd_Date = DateTime.Now;
                model.Crd_By = "1";
                model.Lmd_Date = DateTime.Now;
                model.Lmd_By = "1";
                model.IsActive = true;
                model.IsDeleted = false;
                context.Login_Tbl.Add(model);
                context.SaveChanges();
                n= true;
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