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

    public partial class loan_app_or_rej
    {
        public int loan_id { get; set; }
        public int application_id { get; set; }
        public Nullable<System.DateTime> date_of_approval { get; set; }
        public Nullable<decimal> amount_sanctioned { get; set; }
        public Nullable<double> interest_rate { get; set; }
        public string reasons { get; set; }
        public string status { get; set; }

        public virtual loan_application loan_application { get; set; }
    }

    public enum Status
    {
        pending,
        approved,
        rejected
    }
}
