using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IDesignation
    {
        int DelatedData(int id);
        bool EditData(Designation_Tbl designation_Tbl);
        List<Designation_Tbl> GetData();
        Designation_Tbl GetDataById(int? id);
        bool SaveData(Designation_Tbl designation_Tbl);
    }
}
