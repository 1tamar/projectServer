using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class InleyService
    {
        public static RequestResult GetAll()
        {
            try
            {
                List<InlayDTO> inlay = new List<InlayDTO>();
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {

                    foreach (INLAY item in DB.INLAY)
                    {
                        InlayDTO InlayDTO = new InlayDTO(item);
                        inlay.Add(InlayDTO);
                    }

                }
                return new RequestResult
                {
                    Data = inlay,
                    Messege = "",
                    Status = true
                };
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשליפת הנתונים" +ex.Message,
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
                    DAL.INLAY dalINLAY = DB.INLAY.Find(id);
                    InlayDTO i = new InlayDTO(dalINLAY);
                    return new RequestResult
                    {
                        Data = i,
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
                    Messege = "שגיאה בשליפת השיבוץ",
                    Status = false
                };
            }
        }
        public static RequestResult UpdateRowSource(InlayDTO inlay)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.INLAY dalInlay = DB.INLAY.Find(inlay.InlayID);
                    DB.INLAY.Remove(dalInlay);
                    DB.INLAY.Add(inlay.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = inlay,
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
                    DAL.INLAY dalINLAY = DB.INLAY.Find(id);
                    DB.INLAY.Remove(dalINLAY);
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = null,
                    Messege = "השיבוץ נמחק בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה במחיקת השיבוץ",
                    Status = false
                };
            }
        }
        public static RequestResult Add(InlayDTO inlay)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DB.INLAY.Add(inlay.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = inlay,
                    Messege = "השיבוץ בוצע בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשיבוץ המפגש",
                    Status = false
                };
            }
        }
    }
}
