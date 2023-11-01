using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IEmployee
    {
        int DeletedData(int id);
        bool EditData(Employee_Table employee_Table);
        List<Employee_Table> GetData();
        Employee_Table GetDataById(int? id);
        bool SaveData(Employee_Table employee_Table);
    }
}
