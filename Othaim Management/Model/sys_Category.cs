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
    
    public partial class sys_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_Category()
        {
            this.sys_dev_model = new HashSet<sys_dev_model>();
            this.sys_dev_type = new HashSet<sys_dev_type>();
            this.sys_devices = new HashSet<sys_devices>();
        }
    
        public int category_ID { get; set; }
        public string shrt_id { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_dev_model> sys_dev_model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_dev_type> sys_dev_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_devices> sys_devices { get; set; }
    }
}
