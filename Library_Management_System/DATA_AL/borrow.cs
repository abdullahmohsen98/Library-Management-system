//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management_System.DATA_AL
{
    using System;
    using System.Collections.Generic;
    
    public partial class borrow
    {
        public borrow()
        {
            this.books = new HashSet<book>();
        }
    
        public int br_id { get; set; }
        public Nullable<int> borrower_id { get; set; }
        public Nullable<System.DateTime> br_dateOut { get; set; }
        public Nullable<System.DateTime> br_dateIn { get; set; }
        public Nullable<bool> returned { get; set; }
    
        public virtual borrower borrower { get; set; }
        public virtual ICollection<book> books { get; set; }
    }
}
