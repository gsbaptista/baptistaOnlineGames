using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace OnlineGames.Controllers
{
    [Route("~/GameResults")]
    public class GameResultsController : ApiController
    {
        [HttpPost]
        [Route("~/GameResults")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.Created);
        }

        [HttpGet]
        [Route("~/GameResults")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "");
        }
    }
}
