using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL.Logic
{
    public class Login
    {
        public static RequestResult LoginUser(string userName, string password)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    USERS user = DB.USERS.FirstOrDefault(x => x.USR_NAME == userName && x.USR_PASSWARD == password);
                    return new RequestResult
                    {
                        Data = user,
                        Messege = "הפרטים אומתו בהצלחה",
                        Status = true
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
