using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class RoomTypeDTO
    {
        public int TypeID;
        public string TypeName;
      
        public RoomTypeDTO()
        {

        }
        public RoomTypeDTO(int typeID,string typeName)
        {
            this.TypeID = typeID;
            this.TypeName = typeName;
        }
        public RoomTypeDTO(ROOM_TYPE type)
        {
            this.TypeID = type.TYPE_ID;
            this.TypeName = type.TYPE_NAME;
        }
        public ROOM_TYPE ConvertToDAL()
        {
            ROOM_TYPE type = new ROOM_TYPE();
            type.TYPE_ID = this.TypeID;
            type.TYPE_NAME= this.TypeName;
            return type;
        }
    }
}
