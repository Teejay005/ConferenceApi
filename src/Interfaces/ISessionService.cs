using ConferenceApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConferenceApi.Interfaces
{
    public interface ISessionService
    {
        public List<Session> GetSessions();

        public Task<List<Session>> GetSessionsFor(string speakerName, string date, string timeSlot);
    }
}