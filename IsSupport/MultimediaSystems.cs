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
    
    public partial class MultimediaSystems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MultimediaSystems()
        {
            this.Computers = new HashSet<Computers>();
            this.Equipments = new HashSet<Equipments>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public int RoomID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Computers> Computers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipments> Equipments { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
