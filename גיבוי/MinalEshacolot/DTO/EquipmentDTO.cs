using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class EquipmentDTO
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public EquipmentDTO()
        {

        }
        public EquipmentDTO(int ItemId, string ItemName, int ItemCount)
        {
           this.ItemId = ItemId;
           this.ItemName = ItemName;
           this.ItemCount = ItemCount;
        }
        public EquipmentDTO(DAL.EQUIPMENT equipment)
        {
            this.ItemId = equipment.ITEM_ID;
            this.ItemName = equipment.ITEM_NAME;
        }

        public DAL.EQUIPMENT ConvertToDAL()
        {
            EQUIPMENT equipment = new  EQUIPMENT();
            equipment.ITEM_ID = this.ItemId;
            equipment.ITEM_NAME = this.ItemName;
            return equipment;
        }
    }
}
