//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobIT
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
<<<<<<< Updated upstream
            this.Companies = new HashSet<Company>();
=======
>>>>>>> Stashed changes
            this.People = new HashSet<Person>();
        }
    
        public int UserID { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public int UserTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
<<<<<<< Updated upstream
        public virtual ICollection<Company> Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
        public virtual UserType UserType { get; set; }
=======
        public virtual ICollection<Person> People { get; set; }
>>>>>>> Stashed changes
    }
}
