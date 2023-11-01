using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IQualification
    {
        int DeleteData(int id);
        bool EditData(Qualification_Tbl qualification_Tbl);
        List<Qualification_Tbl> GetAll();
        Qualification_Tbl GetDataByID(int? id);
        bool SaveData(Qualification_Tbl qualification_Tbl);
    }
}
