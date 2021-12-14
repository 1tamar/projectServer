using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class RoomTypeService
    {
        public static RequestResult GetAll()
        {
            try
            {
                List<RoomTypeDTO> roomTypes = new List<RoomTypeDTO>();
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    foreach (ROOM_TYPE item in DB.ROOM_TYPE)
                    {
                        RoomTypeDTO roomTypeDTO = new RoomTypeDTO(item);
                        roomTypes.Add(roomTypeDTO);
                    }
                }
                return new RequestResult
                {
                    Data = roomTypes,
                    Messege = "",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשליפת הנתונים",
                    Status = false
                };
            }
        }
        public static RequestResult GetById(int id)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.ROOM_TYPE dalRoomType = DB.ROOM_TYPE.Find(id);
                    RoomTypeDTO rt = new RoomTypeDTO(dalRoomType);
                    return new RequestResult
                    {
                        Data = rt,
                        Messege = "",
                        Status = true
                    };
                }

            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשליפת  סוג החדר",
                    Status = false
                };
            }
        }
        public static RequestResult UpdateRowSource(RoomTypeDTO roomType)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.ROOM_TYPE dalRoomType = DB.ROOM_TYPE.Find(roomType.TypeID);
                    DB.ROOM_TYPE.Remove(dalRoomType);
                    DB.ROOM_TYPE.Add(roomType.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = roomType,
                    Messege = "השינויים נשמרו בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשמירת השינויים",
                    Status = false
                };
            }
        }
        public static RequestResult Delete(int id)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.ROOM_TYPE dalRoomType = DB.ROOM_TYPE.Find(id);
                    DB.ROOM_TYPE.Remove(dalRoomType);
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = null,
                    Messege = "סוג החדר נמחק בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה במחיקת סוג החדר",
                    Status = false
                };
            }
        }
        public static RequestResult Add(RoomTypeDTO roomType)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DB.ROOM_TYPE.Add(roomType.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = roomType,
                    Messege = "הרישום בוצע בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשמירת הנתונים",
                    Status = false
                };
            }
        }
    }
}
