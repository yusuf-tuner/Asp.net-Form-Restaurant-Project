//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjeRestaurant.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLBasket
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Piece { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string TableID { get; set; }
        public Nullable<int> UserID { get; set; }
    }
}