//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLMSGroup2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registration()
        {
            this.loan_application = new HashSet<loan_application>();
        }

        public int reg_id { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public string gender { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public string address { get; set; }
        public string username { get; set; }
        [Display(Name = "Enter Password")]
        public string password { get; set; }
        public string email_id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string status { get; set; }
        [NotMapped]
        [Compare("password")]
        [Display(Name = "Confirm Password")]
        public string cpassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<loan_application> loan_application { get; set; }
        public virtual registration_remark registration_remark { get; set; }
    }
}
