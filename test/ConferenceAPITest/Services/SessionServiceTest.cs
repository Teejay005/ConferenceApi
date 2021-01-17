using ConferenceApi.Interfaces;
using ConferenceApi.Services;
using Xunit;

namespace ConferenceAPITest.Services
{
    public class SessionServiceTest
    {
        [Fact]
        public void SessionService_GetAllSessions()
        {
            ISessionService sessionService = new SessionService();

            Assert.Equal(2, sessionService.GetSessions().Count);
        }

        [Fact]
        public void SessionService_GetAllSessionsForSpecificSpeakerAndTimeSlot()
        {
            ISessionService sessionService = new SessionService();
            var name = "Tim Davis";
            var date = "21/12/2020";
            var timeSlot = "15:00 - 16:00";
            Assert.Single(sessionService.GetSessionsFor(name, date, timeSlot).Result);
        }

        [Fact]
        public void SessionService_EmptyWhenAllCriteriaDidNotMatch()
        {
            ISessionService sessionService = new SessionService();
            var name = "Tim Davis";
            var date = "21/12/2020";
            var timeSlot = "11:00 - 12:00";
            Assert.Empty(sessionService.GetSessionsFor(name, date, timeSlot).Result);
        }
    }
}
