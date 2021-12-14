using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.Logic
{
    public class Signup
    {
        public static RequestResult SignupUser(string userName,string address, string password)
        {
            try
            {
                using (MinalEshcolotEntities DB = new MinalEshcolotEntities())
                {
                    //USERS user = DB.USERS.First(x => x.USR_ADDRESS == address);
                    bool ser = DB.USERS.Any(x => x.USR_ADDRESS == address);

                    if (ser == true)
                    {
                        return new RequestResult
                        {
                            Data = null,
                            Messege = "קיים כבר משתמש בשם זה, אנא בחר שם שונה.",
                            Status = false
                        };
                    }
                    else
                    {
                        //ליצור משתמש חדש בשם זה ולהכניס למערכת ולהכנס למערכת עם המשתמש החדש.
                        int id = DB.USERS.Max(usr => usr.USR_ID);
                        UsersDTO newUser = new UsersDTO(id + 1, userName, 000, "default", address, password);
                        BLL.UserService.Add(newUser);
                        return new RequestResult
                        {
                            Data = newUser,
                            Messege = "נוספת בהצלחה למערכת",
                            Status = true
                        };
                    }
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
