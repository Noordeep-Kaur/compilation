//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            this.JourneyRoutes = new HashSet<JourneyRoute>();
        }
    
        public int TID { get; set; }
        public int BusID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
    
        public virtual BusDetail BusDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JourneyRoute> JourneyRoutes { get; set; }
    }
}
