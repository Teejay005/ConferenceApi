using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ConferenceApi.Controllers
{
    [Route("conference/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes("application/json")]
        public async Task<ActionResult<IEnumerable<Session>>> Get(string speakerName, string date, string timeSlot)
        {
            var sessionTopics =new List<Session>();
            return sessionTopics;
        }
    }
}