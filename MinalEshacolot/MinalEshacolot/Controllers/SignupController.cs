using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BLL;
using DTO;
using System.Web.Http.Cors;

namespace MinalEshacolot.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SignupController : ApiController
    {
        public RequestResult Post( UsersDTO user)
        {
            return BLL.Logic.Signup.SignupUser(user.Name, user.Address, user.passward);
            //return BLL.Logic.Login.LoginUser(user.Name, user.passward);
        }
    }
}