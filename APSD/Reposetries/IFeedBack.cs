using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IFeedBack
    {
        int DeleteData(int id);
        bool EditData(FeedBack_Tbl feedBack_Tbl);
        List<FeedBack_Tbl> GetAll();
        FeedBack_Tbl GetDataByID(int? id);
        bool SaveData(FeedBack_Tbl feedBack_Tbl);
    }
}
