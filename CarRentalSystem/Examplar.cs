//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Examplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examplar()
        {
            this.Rents = new HashSet<Rent>();
            this.Equipments = new HashSet<Equipment>();
        }
    
        public string VIN { get; set; }
        public int CarID { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Fuel_cost { get; set; }
    
        public virtual Car Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
