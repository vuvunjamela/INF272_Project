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
    
    public partial class PersonLanguage
    {
<<<<<<< Updated upstream
        public int PersonLanguageID { get; set; }
        public int PersonID { get; set; }
        public int LanguageID { get; set; }
    
        public virtual Language Language { get; set; }
=======
        public int PersonID { get; set; }
        public int LanguageID { get; set; }
    
>>>>>>> Stashed changes
        public virtual Person Person { get; set; }
    }
}
