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

    public class InleyController : ApiController
    {

        // GET api/inlay
        public RequestResult Get()
        {
            return InleyService.GetAll();
        }

        // GET api/inlay/5
        public RequestResult Get(int id)
        {
            return InleyService.GetById(id);
        }

        // POST api/inlay
        public RequestResult Post(InlayDTO inlay)
        {
           return InleyService.Add(inlay);
        }

        // PUT api/inlay/5
        public RequestResult Put(InlayDTO inlay)
        {
           return InleyService.UpdateRowSource(inlay);
        }

        // DELETE api/inlay/5
        public RequestResult Delete(int id)
        {
           return InleyService.Delete(id);
        }
    }
}