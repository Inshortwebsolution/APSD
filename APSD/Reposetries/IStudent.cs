using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IStudent
    {
        int DeleteData(int id);
        bool EditData(Student_Tbl student_Tbl);
        List<Student_Tbl> GetAll();
        Student_Tbl GetDataByID(int? id);
        bool SaveData(Student_Tbl student_Tbl);
    }
}
