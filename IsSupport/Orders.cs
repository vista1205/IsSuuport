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
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.HistoryOrder = new HashSet<HistoryOrder>();
        }
    
        public int ID { get; set; }
        public Nullable<System.DateTime> DateCreatet { get; set; }
        public Nullable<System.DateTime> DateClose { get; set; }
        public string Description { get; set; }
        public int RoomID { get; set; }
        public int StatusOrderID { get; set; }
        public int EmployeeID { get; set; }
    
        public virtual Employees Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryOrder> HistoryOrder { get; set; }
        public virtual Rooms Rooms { get; set; }
        public virtual StatusOrders StatusOrders { get; set; }
    }
}
