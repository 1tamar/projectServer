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

    public class RoomsController : ApiController
    {
        // GET api/room
        public RequestResult Get()
        {
            return RoomService.GetAll();
        }

        // GET api/room/5
        public RequestResult Get(int id)
        {
            return RoomService.GetById(id);
        }

        // POST api/room
        public RequestResult Post(RoomsDTO room)
        {
           return RoomService.Add(room);
        }

        // PUT api/room/5
        public RequestResult Put(RoomsDTO room)
        {
          return  RoomService.UpdateRowSource(room);
        }

        // DELETE api/room/5
        public RequestResult Delete(int id)
        {
          return  RoomService.Delete(id);
        }
    }
}