using Domain.Entities.GameResult;
using Domain.Interfaces.Service;
using System;
using System.Net.Http;
using System.Web.Http;

namespace OnlineGames.Controllers
{
    /// <summary>
    /// Game Result Controller
    /// </summary>
    [Route("~/GameResults")]
    public class GameResultsController : ApiController
    {
        private IGameResultAppService gameResultAppService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gameResultAppService"></param>
        public GameResultsController(IGameResultAppService gameResultAppService)
        {
            this.gameResultAppService = gameResultAppService;
        }

        /// <summary>
        /// Creates a new instance of Game Result
        /// </summary>
        /// <param name="gameResult">Game Result data</param>
        /// <returns>Service status code</returns>
        [HttpPost]
        [Route("~/GameResults")]
        public HttpResponseMessage Post(GameResult gameResult)
        {
            try
            {
                gameResultAppService.Create(gameResult);

                return Request.CreateResponse(System.Net.HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("~/GameResults")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "");
        }
    }
}
