using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class RoomService
    {
        public static RequestResult GetAll()
        {
            try
            {
                List<RoomsDTO> rooms = new List<RoomsDTO>();

                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {

                    foreach (ROOMS item in DB.ROOMS)
                    {
                        RoomsDTO roomDTO = new RoomsDTO(item);
                        rooms.Add(roomDTO);
                    }
                }
                return new RequestResult
                {
                    Data = rooms,
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
                    DAL.ROOMS dalRoom = DB.ROOMS.Find(id);
                    RoomsDTO r = new RoomsDTO(dalRoom);
                    return new RequestResult
                    {
                        Data = r,
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
                    Messege = "שגיאה בשליפת החדר",
                    Status = false
                };
            }
        }
        public static RequestResult UpdateRowSource(RoomsDTO room)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.ROOMS dalRoom = DB.ROOMS.Find(room.Id);
                    DB.ROOMS.Remove(dalRoom);
                    DB.ROOMS.Add(room.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = room,
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
                    DAL.ROOMS dalRoom = DB.ROOMS.Find(id);
                    DB.ROOMS.Remove(dalRoom);
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = null,
                    Messege = "החדר נמחק בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה במחיקת החדר",
                    Status = false
                };
            }
        }
        public static RequestResult Add(RoomsDTO room)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DB.ROOMS.Add(room.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = room,
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
