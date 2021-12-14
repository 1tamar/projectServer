using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DTO;
using System.Web.Http.Cors;

namespace MinalEshacolot.Controllers

{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        //static MinalEshcolotEntities DB = new MinalEshcolotEntities();
        //RequestResult
        // GET api/user
        //public IEnumerable<DTO.UsersDTO> Get()
        //{
        //    return UserService.GetAll();
        //}
        public   RequestResult Get()
        {
            return UserService.GetAll();
        }

        // GET api/user/5
        //public  UsersDTO Get(int id)
        //{
        //    return UserService.GetById(id);
        //}
        public  RequestResult Get(int id)
        {
            return UserService.GetById(id);
        }

        // POST api/user
        public  RequestResult Post(UsersDTO user)
        {
            return UserService.Add(user);
        }

        // PUT api/user/5
        public  RequestResult Put(UsersDTO user)
        {
          return  UserService.UpdateRowSource(user);
        }

        // DELETE api/user/5
        public RequestResult Delete(int id)
        {
          return   UserService.Delete(id);
        }

        [HttpPost, Route("Login")]
        public RequestResult Login([FromBody] UsersDTO user)
        {
            return BLL.Logic.Login.LoginUser(user.Name, user.passward);
        }
    }
}