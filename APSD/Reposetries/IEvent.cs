using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IEvent
    {
        int DeleteData(int id);
        bool EditData(Event_Tbl event_Tbl);
        List<Event_Tbl> GetData();
        Event_Tbl GetDataById(int? id);
        bool SaveData(Event_Tbl event_Tbl);
    }
}
