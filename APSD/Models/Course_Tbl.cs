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
    
    public partial class Course_Tbl
    {
        public int Course_Id { get; set; }
        public string Course_Name { get; set; }
        public string Course_Description { get; set; }
        public string Course_Duration_IN_Dates { get; set; }
        public string Course_Image { get; set; }
        public Nullable<System.DateTime> Crd_Date { get; set; }
        public string Crd_By { get; set; }
        public Nullable<System.DateTime> Lmd_Date { get; set; }
        public string Lmd_By { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
