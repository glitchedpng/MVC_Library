//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Library.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WRITER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WRITER()
        {
            this.BOOK = new HashSet<BOOK>();
        }
    
        public byte ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string DETAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOK> BOOK { get; set; }
    }
}
