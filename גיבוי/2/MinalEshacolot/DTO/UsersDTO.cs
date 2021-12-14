using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace DTO
{
    public class UsersDTO
    {

        public int Id;
        public string Name;
        public int Phone;
        public string City;
        public string Address;
        public string passward;
        public UsersDTO()
        {

        }
        public UsersDTO(int id,string name, int phone, string city, string address,string passward)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.City = city;
            this.Address = address;
            this.passward = passward;
        }
        public UsersDTO(USERS user)
        {
            this.Id = user.USR_ID;
            this.Name = user.USR_NAME;
           this.Phone =(int)user.USR_PHONE;
            this.City = user.USR_CITY;
            this.Address = user.USR_ADDRESS;
            this.passward = user.USR_PASSWARD;

        }
        public USERS ConvertToDAL()
        {
            USERS user = new USERS();
            user.USR_ID = this.Id;
            user.USR_NAME = this.Name;
            user.USR_PHONE = this.Phone;
            user.USR_CITY = this.City;
            user.USR_ADDRESS = this.Address;
            user.USR_PASSWARD = this.passward;
            return user;
        }
        //public static UsersDTO ConvertUserToDTO(USERS user)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //          cfg.CreateMap<USERS, UsersDTO>()
        //      );
        //    var mapper = new Mapper(config);
        //    return mapper.Map<UsersDTO>(user);
        //}
    }
}
