using PES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PES.Controllers
{
    public class ParticipantController : ApiController
    {


        //Add Action for GET // for Fetch data from database and return to the Client
        public HttpResponseMessage Get()
        {
            List<participant> allparticipant = new List<participant>();
            using (testEntities dc = new testEntities()) //here MyDatabaseEntities is our datacontext
            {
                allparticipant = dc.participants.OrderBy(a => a.name).ToList(); // I have added linq code for fetch data, you can use Sql client for fetch data
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, allparticipant);
                return response;
            }
        }
    }
}
