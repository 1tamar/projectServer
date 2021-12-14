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
        public OtherOption(string typeR, bool accessibilityR, int tannageR)
        {

        }
        public RequestResult GetOtherOption()
        {
            try
            {


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
        
        public RequestResult GetAdapdRooms(string type,bool accessibility ,int tannage)
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
