using ConferenceApi.Interfaces;
using ConferenceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ConferenceApi.Controllers
{
    [Route("conference/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;
        private ISessionService _sessionService;

        public SessionController(ILogger<SessionController> logger, ISessionService sessionService)
        {
            _logger = logger;
            _sessionService = sessionService;
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(ResponseCodes.Bad_Request, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Created, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Internal_Server_Error, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Invalid_Data, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Bad_Request, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.UnathorizedRequest, Type = typeof(ActionResult))]
        [Consumes("application/json")]
        public async Task<ActionResult<IEnumerable<Session>>> Get(string speakerName, string date, string timeSlot)
        {
            _logger.LogInformation($"Request made with following query params: speaker - {speakerName}, date - {date}, timeslot - {timeSlot}");
            var Sessions = new List<Session>();
           
            return Sessions;
        }
    }
}