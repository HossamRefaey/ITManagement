//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Othaim_Management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class sys_doc_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_doc_type()
        {
            this.device_Cycle = new HashSet<device_Cycle>();
            this.STK_HDR = new HashSet<STK_HDR>();
        }
    
        public int doc_type_id { get; set; }
        public string doc_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<device_Cycle> device_Cycle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STK_HDR> STK_HDR { get; set; }
    }
}