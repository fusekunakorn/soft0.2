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
    
    public partial class Room
    {
        public Room()
        {
            this.RentalOrder = new HashSet<RentalOrder>();
            this.Deposit = new HashSet<Deposit>();
        }
    
        public int RoomId { get; set; }
        public double Rent { get; set; }
    
        public virtual ICollection<RentalOrder> RentalOrder { get; set; }
        public virtual ICollection<Deposit> Deposit { get; set; }
    }
}
