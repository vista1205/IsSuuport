//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsSupport
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUnits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemUnits()
        {
            this.SystemUnitComponents = new HashSet<SystemUnitComponents>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string SeralNumber { get; set; }
        public string InventoryNumber { get; set; }
        public Nullable<int> ComputerID { get; set; }
        public int StatusDeviceID { get; set; }
    
        public virtual Computers Computers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemUnitComponents> SystemUnitComponents { get; set; }
    }
}
