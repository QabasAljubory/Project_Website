//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> CustomerFK { get; set; }
        public Nullable<int> CartFK { get; set; }
    
        public virtual Cart Cart { get; set; }
        public virtual Customer Customer { get; set; }
    }
}