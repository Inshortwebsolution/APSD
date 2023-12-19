using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IHome
    {
        List<Course_Tbl> getcoures();
        List<Event_Tbl> getEvent();
        List<FeedBack_Tbl> getFeedback();
        Login_Tbl LoginData(Login_Tbl model);
        
        List<Gallery_Tbl> getVideos();
        bool LoginData(Login_Tbl model);
        bool SignupData(Login_Tbl model);
    }
}
