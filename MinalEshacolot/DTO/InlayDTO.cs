using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class InlayDTO
    {
        public int InlayID { get; set; }
        public DateTime? InlayDate { get; set; }
        public DateTime? FromHour { get; set; }
        public DateTime? ToHour { get; set; }
        public int UserId { get; set; }
        public virtual UsersDTO User { get; set; }
        public List<InlayEuipmentDTO> Equipments { get; set; }
        public virtual List<RoomsDTO> Rooms { get; set; }
        public int ONE_TIME_OR_WEEKLY { get; set; }
        public int SEVERAL_SESSIONS { get; set; }
        public InlayDTO()
        {

        }
        public InlayDTO(int inlayID, DateTime inlayDate, DateTime fromHour, DateTime toHour, int userId, UsersDTO User, List<InlayEuipmentDTO> equipment, List<RoomsDTO> rooms,int one_time_or_weekly,int several_session)
        {
            this.InlayID = inlayID;
            this.InlayDate = inlayDate;
            this.FromHour = fromHour;
            this.ToHour = toHour;
            this.UserId = userId;
            this.User = User;
            this.Equipments = equipment;
            this.Rooms = rooms;
            this.ONE_TIME_OR_WEEKLY = one_time_or_weekly;
            this.SEVERAL_SESSIONS = several_session;
        }
        public InlayDTO(DAL.INLAY inlay)
        {
            this.InlayID = inlay.INLAY_ID;
            this.InlayDate = inlay.INLAY_DATE!=null?(DateTime?)inlay.INLAY_DATE:(DateTime?)null;
            this.FromHour = inlay.FROM_HOUER!=null? (DateTime?)inlay.FROM_HOUER: (DateTime?)null;
            this.ToHour = inlay.TO_HOUER != null ? (DateTime?)inlay.TO_HOUER: (DateTime?)null;
            this.UserId = (int)inlay.USR_ID;
            this.User =new UsersDTO (inlay.USERS);
            List<InlayEuipmentDTO> inEq = new List<InlayEuipmentDTO>();
            foreach (INLAY_EQUIPMENT dalIn in inlay.INLAY_EQUIPMENT)
            {
                inEq.Add(new InlayEuipmentDTO(dalIn));
            }
            this.Equipments = inEq;
           // this.Rooms =new RoomsDTO(inlay.ROOMS);
            this.ONE_TIME_OR_WEEKLY = (int)inlay.ONE_TIME_OR_WEEKLY;
            this.SEVERAL_SESSIONS =(int) inlay.SEVERAL_SESSIONS;


        }
        public DAL.INLAY ConvertToDAL()
        {
            INLAY inlay = new INLAY();

            inlay.INLAY_ID = this.InlayID;
            inlay.INLAY_DATE = this.InlayDate;
            inlay.FROM_HOUER = this.FromHour;
            inlay.TO_HOUER = this.ToHour;
            inlay.USR_ID = this.UserId;
            inlay.USERS = this.User.ConvertToDAL();
            inlay.ONE_TIME_OR_WEEKLY = this.ONE_TIME_OR_WEEKLY;
            inlay.SEVERAL_SESSIONS = this.SEVERAL_SESSIONS;
            List<INLAY_EQUIPMENT> inEq = new List<INLAY_EQUIPMENT>();
            foreach (InlayEuipmentDTO item in this.Equipments)
            {
                inEq.Add(item.ConvertToDAL());
            }
            inlay.INLAY_EQUIPMENT = inEq;
            // inlay.ROOMS = this.Rooms;

            return inlay;
        }

    }
}
