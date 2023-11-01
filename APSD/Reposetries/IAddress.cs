using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IAddress
    {
        int DeletedData(int id);
        bool EditData(Address_Tbl address_Tbl);
        List<Address_Tbl> GetData();
        Address_Tbl GetDataById(int? id);
        bool SaveData(Address_Tbl address_Tbl);
    }
}
