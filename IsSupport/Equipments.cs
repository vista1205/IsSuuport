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
    
    public partial class Equipments
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int TypeEquipmentID { get; set; }
        public string SerialNumber { get; set; }
        public string InventoryNumber { get; set; }
        public Nullable<int> StatusDeviceID { get; set; }
        public string Description { get; set; }
        public Nullable<int> MultimediaSystemID { get; set; }
    
        public virtual MultimediaSystems MultimediaSystems { get; set; }
        public virtual StatusDevice StatusDevice { get; set; }
        public virtual TypesEquipment TypesEquipment { get; set; }
    }
}
