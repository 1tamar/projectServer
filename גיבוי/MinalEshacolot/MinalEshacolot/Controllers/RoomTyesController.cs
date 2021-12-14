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

    public class RoomTyesController : ApiController
    {
        // GET api/roomType
        public RequestResult Get()
        {
            return RoomTypeService.GetAll();
        }

        // GET api/roomType/5
        public RequestResult Get(int id)
        {
            return RoomTypeService.GetById(id);
        }

        // POST api/roomType
        public RequestResult Post(RoomTypeDTO roomType)
        {
          return RoomTypeService.Add(roomType);
        }

        // PUT api/roomType/5
        public RequestResult Put(RoomTypeDTO roomType)
        {
           return RoomTypeService.UpdateRowSource(roomType);
        }

        // DELETE api/roomType/5
        public RequestResult Delete(int id)
        {
          return  RoomTypeService.Delete(id);
        }
    }
}