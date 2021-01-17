using ConferenceApi.Attributes;
using ConferenceApi.Interfaces;
using ConferenceApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ConferenceApi.Controllers
{
    [Route("conference/[controller]")]
    [Security]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ILogger<SessionController> _logger;
        private ISessionService _sessionService;
        private IValidationService _validationService;

        public SessionController(ILogger<SessionController> logger, ISessionService sessionService, IValidationService validationService)
        {
            _logger = logger;
            _sessionService = sessionService;
            _validationService = validationService;
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(ResponseCodes.Bad_Request, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Success, Type = typeof(List<Session>))]
        [ProducesResponseType(ResponseCodes.Internal_Server_Error, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Invalid_Data, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.Bad_Request, Type = typeof(ActionResult))]
        [ProducesResponseType(ResponseCodes.UnathorizedRequest, Type = typeof(ActionResult))]
        [Consumes("application/json")]
        public async Task<ActionResult<IEnumerable<Session>>> Get(string speakerName, string date, string timeSlot)
        {
            _logger.LogInformation($"Request made with following query params: speaker - {speakerName}, date - {date}, timeslot - {timeSlot}");

            if (!_validationService.ValidateRequestParameters(speakerName, date, timeSlot))
            {
                _logger.LogError("Exception was throw for supplying invalid parameters");
                 throw new ConferenceAPIException("Ensure all parameters are supplied");
            }
            var Sessions = await _sessionService.GetSessionsFor(speakerName, date, timeSlot);
           
            return Sessions;
        }
    }
}