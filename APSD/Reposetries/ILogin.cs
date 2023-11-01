using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface ILogin
    {
        int DeleteData(int id);
        bool EditData(Login_Tbl login_Tbl);
        Login_Tbl GetAllDataById(int? id);
        List<Login_Tbl> GetData();
        bool SaveData(Login_Tbl login_Tbl);
    }
}
