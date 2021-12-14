using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public static class EquipmentService
    {
        public static RequestResult GetAll()
        {
            try
            {
                List<EquipmentDTO> equipments = new List<EquipmentDTO>();
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {

                    foreach (EQUIPMENT item in DB.EQUIPMENT)
                    {
                        EquipmentDTO equipmentDTO = new EquipmentDTO(item);
                        equipments.Add(equipmentDTO);
                    }
                }
                return new RequestResult
                {
                    Data = equipments,
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

                    DAL.EQUIPMENT dalEquipment = DB.EQUIPMENT.Find(id);
                    EquipmentDTO e = new EquipmentDTO(dalEquipment);
                    return new RequestResult
                    {
                        Data = e,
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
                    Messege = "שגיאה בשליפת הפריט",
                    Status = false
                };
            }
        }
        public static RequestResult UpdateRowSource(EquipmentDTO equipment)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.EQUIPMENT dalEquipment = DB.EQUIPMENT.Find(equipment.ItemId);
                    DB.EQUIPMENT.Remove(dalEquipment);
                    DB.EQUIPMENT.Add(equipment.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = equipment,
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
                    DAL.EQUIPMENT dalEquipment = DB.EQUIPMENT.Find(id);
                    DB.EQUIPMENT.Remove(dalEquipment);
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = null,
                    Messege = "הפריט נמחק בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה במחיקת הפריט",
                    Status = false
                };
            }
        }
        public static RequestResult Add(EquipmentDTO equipment)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DB.EQUIPMENT.Add(equipment.ConvertToDAL());
                            DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = equipment,
                    Messege = "ההוספה בוצעה בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בהוספת הפריט",
                    Status = false
                };
            }
        }
    }
}
