using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL.Logic
{
    class OtherOption
    {
        public OtherOption(string typeR, bool accessibilityR, int tonnageR)
        {
           GetAdapdRooms(typeR, accessibilityR, tonnageR) ;

        }
        public RequestResult GetOtherOption(DateTime startT,DateTime endT,DateTime[]dates,int length)
        {
            try
            {
                
                int minutes=endT.Minute - startT.Minute;
                List<ROOMS> rooms = new List<ROOMS>();
                List<EQUIPMENT> notFlexibility = new List<EQUIPMENT>();
                List<EQUIPMENT> flexibility = new List<EQUIPMENT>();
                //כאילו יש לנו מערכים (כאורך מערך התאריכים) מחולק לרבעי שעות 
                int count = length / 15;
                count += length % 15 > 0 ? 1 : 0;
                for (int i = 0; i < length; i++)//עובר על כל המערכים 
                {
                    for (int j = 0; j < length; j++)//עובר על כל הרבעי שעות
                    {

                    }
                }
                
                               

                return new RequestResult
                {
                    Data = null,
                    Messege = "",
                    Status = true
                };
            }
            catch
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "",
                    Status = false
                };
            }
        }

        public RequestResult GetAdapdRooms(string type, bool accessibility, int tannage)
        {
            try
            {
                //הולך לדטהבייס לפרוצדורה שמחזירה את החדרים שעונים לתנאי.
                return new RequestResult
                {
                    Data = null,//רשימת החדרים
                    Messege = "",
                    Status = true
                };
            }
            catch
            {
                return new RequestResult
                {
                    Data = null,
                    Messege = "",
                    Status = false
                };
            }
        }
    }
}
