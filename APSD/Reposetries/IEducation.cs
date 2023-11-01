using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IEducation
    {
        int DeleteData(int id);
        bool EditData(Education_Tbl education_Tbl);
        List<Education_Tbl> GetAll();
        Education_Tbl GetDataByID(int? id);
        bool SaveData(Education_Tbl education_Tbl);
    }
}
