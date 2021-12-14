using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class RoomsDTO
    {

        public int Id;
        public string Name;
        public int Floor;
        public int TONNAGE;
        public int Type;
        public RoomTypeDTO Type1;  
        public RoomsDTO()
        {

        }
        public RoomsDTO(int id, string name, int floor, int TONNAGE, int type, RoomTypeDTO type1)
        {
            this.Id = id;
            this.Name = name;
            this.Floor = floor;
            this.TONNAGE = TONNAGE;
            this.Type = type;
            this.Type1 = type1;
        }
  
        public RoomsDTO(DAL.ROOMS room)
        {
            this.Floor = (int)room.ROOM_FLOOR;
            this.Id = room.ROOM_ID;
            this.Name = room.ROOM_NAME;
            this.TONNAGE =(int) room.ROOM_TONNAGE;
            this.Type =(int) room.ROOM_TYPE;
          //  this.Type1 = room.ROOM_TYPE1;
        }
        public DAL.ROOMS ConvertToDAL()
        {
            ROOMS room = new ROOMS();
            room.ROOM_FLOOR = this.Floor;
            room.ROOM_ID = this.Id;
            room.ROOM_NAME=this.Name;
            room.ROOM_TONNAGE = this.TONNAGE;
            room.ROOM_TYPE = this.Type;
      //      room.ROOM_TYPE1 = this.Type1;
            return room;
        }


    }
}
