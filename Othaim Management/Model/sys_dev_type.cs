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
    
    public partial class sys_dev_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_dev_type()
        {
            this.sys_dev_model = new HashSet<sys_dev_model>();
            this.sys_devices = new HashSet<sys_devices>();
        }
    
        public int devType_ID { get; set; }
        public string dev_type { get; set; }
        public Nullable<int> Category_ID { get; set; }
    
        public virtual sys_Category sys_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_dev_model> sys_dev_model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_devices> sys_devices { get; set; }
    }
}
