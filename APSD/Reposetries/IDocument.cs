using APSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSD.Reposetries
{
    internal interface IDocument
    {
        int DeleteData(int id);
        bool EditData(Document_Tbl document_Tbl);
        List<Document_Tbl> GetData();
        Document_Tbl GetDataById(int? id);
        bool Saveadata(Document_Tbl document_Tbl);
    }
}
