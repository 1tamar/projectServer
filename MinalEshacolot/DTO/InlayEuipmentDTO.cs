using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class InlayEuipmentDTO
    {
        public EquipmentDTO Equipment { get; set; }
        public int Count { get; set; }

        public InlayEuipmentDTO()
        {


        }
        public InlayEuipmentDTO(EquipmentDTO Equipment,int count)
        {

        }

        public InlayEuipmentDTO(INLAY_EQUIPMENT dalInlay)
        {
            Equipment=new EquipmentDTO(dalInlay.EQUIPMENT);
            Count =(int) dalInlay.ITEM_COUNT;
        }
        public DAL.INLAY_EQUIPMENT ConvertToDAL()
        {
            INLAY_EQUIPMENT inEq = new INLAY_EQUIPMENT();
            inEq.EQUIPMENT = this.Equipment.ConvertToDAL();
            inEq.ITEM_COUNT = Count;
            return inEq;
        }
    }
}
