//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSupport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answears
    {
        public int AnswearId { get; set; }
        public string AnswearType { get; set; }
        public string AnswearText { get; set; }
        public Nullable<int> AnswearTypeId { get; set; }
        public string AnswearTitle { get; set; }
    
        public virtual AnswearsTypes AnswearsTypes { get; set; }
    }
}
