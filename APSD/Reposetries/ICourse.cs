using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface ICourse
    {
        int DeleteData(int? id);
        bool EditData(Course_Tbl course_Tbl);
        List<Course_Tbl> GetAll();
        Course_Tbl GetDataByID(int? id);
        bool SaveData(Course_Tbl course_Tbl);
    }
}
