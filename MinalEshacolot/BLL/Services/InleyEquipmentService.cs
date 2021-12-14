using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Services
{
    class InleyEquipmentService
    {
        //public static RequestResult GetAll()
        //{
        //    try
        //    {
        //        List<InlayEuipmentDTO> inEq = new List<InlayEuipmentDTO>();
        //        using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
        //        {
        //            foreach (INLAY_EQUIPMENT item in DB.INLAY_EQUIPMENT)
        //            {
        //                InlayEuipmentDTO inEquipmentDTO = new InlayEuipmentDTO(item);
        //                inEq.Add(inEquipmentDTO);
        //            }
        //        }
        //        return new RequestResult
        //        {
        //            Data = inEq,
        //            Messege = "",
        //            Status = true
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "שגיאה בשליפת הנתונים",
        //            Status = false
        //        };
        //    }
        //}

        //public static RequestResult GetById(int id)
        //{
        //    try
        //    {
        //        using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
        //        {

        //            DAL.INLAY_EQUIPMENT dalInlayEquipment = DB.INLAY_EQUIPMENT.Find(id);
        //            EquipmentDTO e = new EquipmentDTO(dalInlayEquipment);
        //            return new RequestResult
        //            {
        //                Data = e,
        //                Messege = "",
        //                Status = true
        //            };
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "שגיאה בשליפת הפריט",
        //            Status = false
        //        };
        //    }
        //}

        //public static RequestResult UpdateRowSource(EquipmentDTO equipment)
        //{
        //    try
        //    {
        //        using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
        //        {
        //            DAL.EQUIPMENT dalEquipment = DB.EQUIPMENT.Find(equipment.ItemId);
        //            DB.EQUIPMENT.Remove(dalEquipment);
        //            DB.EQUIPMENT.Add(equipment.ConvertToDAL());
        //            DB.SaveChanges();
        //        }
        //        return new RequestResult
        //        {
        //            Data = equipment,
        //            Messege = "השינויים נשמרו בהצלחה",
        //            Status = true
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "שגיאה בשמירת השינויים",
        //            Status = false
        //        };
        //    }
        //}

        //public static RequestResult Delete(int id)
        //{
        //    try
        //    {
        //        using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
        //        {
        //            DAL.EQUIPMENT dalEquipment = DB.EQUIPMENT.Find(id);
        //            DB.EQUIPMENT.Remove(dalEquipment);
        //            DB.SaveChanges();
        //        }
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "הפריט נמחק בהצלחה",
        //            Status = true
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "שגיאה במחיקת הפריט",
        //            Status = false
        //        };
        //    }
        //}


        //public static RequestResult Add(EquipmentDTO equipment)
        //{
        //    try
        //    {
        //        using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
        //        {
        //            DB.EQUIPMENT.Add(equipment.ConvertToDAL());
        //            DB.SaveChanges();
        //        }
        //        return new RequestResult
        //        {
        //            Data = equipment,
        //            Messege = "ההוספה בוצעה בהצלחה",
        //            Status = true
        //        };
        //    }
        //    catch (Exception)
        //    {
        //        return new RequestResult
        //        {
        //            Data = null,
        //            Messege = "שגיאה בהוספת הפריט",
        //            Status = false
        //        };
        //    }
        //}
    }
}
