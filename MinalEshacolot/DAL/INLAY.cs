//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class INLAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INLAY()
        {
            this.INLAY_EQUIPMENT = new HashSet<INLAY_EQUIPMENT>();
            this.ROOMS = new HashSet<ROOMS>();
        }
    
        public int INLAY_ID { get; set; }
        public Nullable<System.DateTime> INLAY_DATE { get; set; }
        public Nullable<System.DateTime> FROM_HOUER { get; set; }
        public Nullable<System.DateTime> TO_HOUER { get; set; }
        public Nullable<int> USR_ID { get; set; }
        public Nullable<int> ONE_TIME_OR_WEEKLY { get; set; }
        public Nullable<int> SEVERAL_SESSIONS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INLAY_EQUIPMENT> INLAY_EQUIPMENT { get; set; }
        public virtual USERS USERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOMS> ROOMS { get; set; }
    }
}