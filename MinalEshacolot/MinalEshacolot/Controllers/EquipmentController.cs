using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;



namespace MinalEshacolot.Controllers
{
    [EnableCors("*", "*", "*")]
    public class EquipmentController : ApiController
    {
        // GET api/equipment
        public RequestResult Get()
        {
            return EquipmentService.GetAll();
        }

        // GET api/equipment/5
        public RequestResult Get(int id)
        {
            return EquipmentService.GetById(id);
        }

        // POST api/equipment
        public RequestResult Post(EquipmentDTO equipment)
        {
            return EquipmentService.Add(equipment);
        }

        // PUT api/equipment/5
        public RequestResult Put(EquipmentDTO equipment)
        {
            return EquipmentService.UpdateRowSource(equipment);
        }

        // DELETE api/equipment/5
        public RequestResult Delete(int id)
        {
            return EquipmentService.Delete(id);
        }
    }
}