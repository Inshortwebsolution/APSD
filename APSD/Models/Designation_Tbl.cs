//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APSD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Designation_Tbl
    {
        public int Designation_Id { get; set; }
        public string Des_Tittle { get; set; }
        public string Des_Description { get; set; }
        public Nullable<System.DateTime> Crd_Date { get; set; }
        public string Crd_By { get; set; }
        public Nullable<System.DateTime> Lmd_Date { get; set; }
        public string Lmd_By { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}