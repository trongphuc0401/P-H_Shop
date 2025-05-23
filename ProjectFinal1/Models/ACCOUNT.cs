//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectFinal1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT()
        {
            this.ARTICLES = new HashSet<ARTICLE>();
            this.ORDERS = new HashSet<ORDER>();
            this.PRODUCTS = new HashSet<PRODUCT>();
        }
    
        public string ACCOUNT1 { get; set; }
        public string PASS { get; set; }
        public string SURNAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> BIRTHDAY { get; set; }
        public Nullable<bool> SEX { get; set; }
        public string P_NUMBER { get; set; }
        public string EMAIL { get; set; }
        public string HOME_AD { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public string NOTE { get; set; }
        public string NAME_ACCOUNT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICLE> ARTICLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER> ORDERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }
    }
}
