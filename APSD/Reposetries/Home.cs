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
        public bool LoginData(Login_Tbl model)
        {
            bool n= false;
            try
            {
                model.Type=model.Type;
                model.LastLoginDate=DateTime.Now;
                model.Crd_Date = DateTime.Now;
                model.Crd_By = "1";
                model.Lmd_Date = DateTime.Now;
                model.Lmd_By = "1";
                model.IsActive = true;
                model.IsDeleted = false;
                bool isValid = context.Login_Tbl.Any(x => x.User_Id == model.User_Id && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.User_Id.ToString(), false);
                    n= true;
                    return n;
                }
                else
                {
                    MessageBox.Show("Invalid UserName And Password !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return false;
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