using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Logic
{
    class AddAction
    {
        public static RequestResult GetPossibleRooms(int floor, int type, int tonage, DateTime date)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    //List<ROOMS> allRooms = new List<ROOMS>(DB.ROOMS);
                    //List<INLAY_ROOMS> list = new List<INLAY_ROOMS>();
                    //List<INLAY> allInlays = new List<INLAY>(DB.INLAY);
                    //List<int> roomsId = new List<int>();
                    //allRooms.ForEach(x =>
                    //{
                    //    if (((x.ROOM_FLOOR == floor&&floor==0)||(x.ROOM_FLOOR >= floor && floor != 0)) &&//נגיש
                    //    (x.ROOM_TONNAGE >= tonage) &&
                    //    (x.ROOM_TYPE == type))
                    //        roomsId.Add(x.ROOM_ID);
                    //}
                    //);
                    //foreach (ROOMS room in allRooms)
                    //{
                    //    list.Add( DB.INLAY_ROOMS.where(r => room.ROOM_ID == r.ROOM_ID));
                    //}
                    //foreach (INLAY_ROOMS inlayRoom in list)
                    //{
                    //    allInlays.Add( DB.INLAY.where(i => i.INLAY_ID == inlayRoom.INLAY_ID&& INLAY_DATE==date));
                    //}
                    //List<INLAY> inlayes = new List<INLAY>();
                    //List<INLAY> newInlayes = new List<INLAY>();
                    ////return allInlays
                    return new RequestResult
                    {
                        Data = "",// allRooms,
                        Messege = "רשימת החדרים האפשריים נמצאה",
                        Status = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "אין חדרים המתאימים לדרישות.",
                    Status = false
                };
            }
        }
        public static RequestResult GetPossibleItems(List<Tuple<int,int,bool>>items)
        {
            // 1  5
            // 2  7
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    return new RequestResult
                    {
                        Data = "hhh",//------
                        Messege = "רשימת החדרים האפשריים נמצאה",
                        Status = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "אין חדרים המתאימים לדרישות.",
                    Status = false
                };
            }
        }
        public static RequestResult updateUser()
        {
            //show result
            //if wont -> AddingAction
            //else  if other by computer -> find other option
            //       else -> nothing!
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    return new RequestResult
                    {
                        Data = "hhh",//------
                        Messege = "רשימת החדרים האפשריים נמצאה",
                        Status = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "אין חדרים המתאימים לדרישות.",
                    Status = false
                };
            }
        }
        public static RequestResult AddingAction(INLAY inlay,INLAY_EQUIPMENT inEq)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                
                    
                    return new RequestResult
                    {
                        Data = inlay,
                        Messege = "הפעילות הוספה בהצלחה",
                        Status = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "אין אפשרות",
                    Status = false
                };
            }
        }
        public static RequestResult OtherOption()
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    return new RequestResult
                    {
                        Data = "hh",
                        Messege = "הפעילות הוספה בהצלחה",
                        Status = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "אין אפשרות",
                    Status = false
                };
            }
        }
    }
}
