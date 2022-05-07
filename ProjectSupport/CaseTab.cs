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
    
    public partial class CaseTab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaseTab()
        {
            this.AdminChat = new HashSet<AdminChat>();
            this.UserChat = new HashSet<UserChat>();
        }
    
        public int CaseId { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string CaseStatus { get; set; }
        public string CaseName { get; set; }
    
        public virtual Transactions Transactions { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminChat> AdminChat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserChat> UserChat { get; set; }
    }
}
