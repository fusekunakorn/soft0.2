//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace softpro
{
    using System;
    using System.Collections.Generic;
    
    public partial class RentalOrder
    {
        public int Id { get; set; }
        public System.DateTime RetalDate { get; set; }
        public int Unit { get; set; }
        public int Person { get; set; }
        public double WaterPrice { get; set; }
        public double Total { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}