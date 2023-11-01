using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IUploadeVideo
    {
        List<Gallery_Tbl> GetAll();
        bool SaveData(Gallery_Tbl gallery_Tbl);
        bool Edit(Gallery_Tbl gallery_Tbl);
        int DeleteData(int? id);
        Gallery_Tbl GetDataByID(int? id);
        //bool Delete(Gallery_Tbl gallery_Tbl);


    }
}
