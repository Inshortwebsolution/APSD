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
    }
}
