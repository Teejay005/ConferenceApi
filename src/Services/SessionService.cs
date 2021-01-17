using ConferenceApi.Interfaces;
using ConferenceApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApi.Services
{
    public class SessionService : ISessionService
    {
        public List<Session> GetSessions()
        {
            return Stubs.SessionStub.CreateSessions();
        }

        public async Task<List<Session>> GetSessionsFor(string speakerName, string date, string timeSlot)
        {
            return GetSessions().Where(x => x.Speaker.Name == speakerName && x.Date == date && x.Timeslot == timeSlot).ToList();
        }
    }
}