using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IPlacement
    {
        int DeletedData(int id);
        bool EditData(Placement_Tbl placement_Tbl);
        List<Placement_Tbl> GetData();
        Placement_Tbl GetDataById(int? id);
        List<Placement_Tbl> getPlacement();
        bool SaveData(Placement_Tbl placement_Tbl);
    }
}
