using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class UserService
    {
        public static RequestResult GetAll()
        {
            try
            {
                List<UsersDTO> users = new List<UsersDTO>();
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {

                    foreach (USERS item in DB.USERS)
                    {
                        UsersDTO usersDTO = new UsersDTO(item);
                        users.Add(usersDTO);
                    }
                    return new RequestResult
                    {
                        Data = users,
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
                    DAL.USERS dalUser = DB.USERS.Find(id);
                    UsersDTO u = new UsersDTO(dalUser);
                    return new RequestResult
                    {
                        Data = u,
                        Messege = "",
                        Status = true
                    };
                }
            }

            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה בשליפת המשתמש",
                    Status = false
                };
            }
        }
        public static RequestResult UpdateRowSource(UsersDTO user)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DAL.USERS dalUser = DB.USERS.Find(user.Id);
                    DB.USERS.Remove(dalUser);
                    DB.USERS.Add(user.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = user,
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
                    DAL.USERS dalUser = DB.USERS.Find(id);
                    DB.USERS.Remove(dalUser);
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = null,
                    Messege = "המשתמש נמחק בהצלחה",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שגיאה במחיקת המשתמש",
                    Status = false
                };
            }
        }
        public static RequestResult Add(UsersDTO user)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    DB.USERS.Add(user.ConvertToDAL());
                    DB.SaveChanges();
                }
                return new RequestResult
                {
                    Data = user,
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
