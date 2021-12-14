using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Logic
{
    public class Login
    {
        public static RequestResult LoginUser(string address, string password)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    USERS user = DB.USERS.FirstOrDefault(x => x.USR_ADDRESS == address && x.USR_PASSWARD == password);
                    if(user!=null)
                        return new RequestResult
                        {
                            Data = new UsersDTO(user),
                            Messege = "הפרטים אומתו בהצלחה",
                            Status = true
                        };
                    else
                        return new RequestResult
                        {
                            Data = user,
                            Messege = "שם משתמש או סיסמא שגויים, נסה שנית",
                            Status = false
                        };
                }
            }
            catch (Exception ex)
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "שם משתמש/סימה שגויים, נסה שנית",
                    Status = false
                };
            }
        }
    }
}

