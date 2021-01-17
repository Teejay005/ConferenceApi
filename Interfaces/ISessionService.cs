using ConferenceApi.Models;
using System.Collections.Generic;

namespace ConferenceApi.Interfaces
{
    public interface ISessionService
    {
        public List<Session> GetSessions();

        public List<Session> GetSessionsFor(string speakerName, string date, string timeSlot);
    }
}