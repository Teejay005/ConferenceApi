using ConferenceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApi.Stubs
{
    public static class SessionStub
    {
        public static List<Session> CreateSessions()
        {
            return new List<Session> {
                new Session
                {
                    Speaker = new Speaker {Name = "Tim Davis"},
                    Timeslot = "15:00 - 16:00",
                    Title = "Agile",
                    Date = "21/12/2020",
                    Topics = new List<Topic>
                    {
                        new Topic
                        {
                            Title = "ASP.NET Web API 2: HTTP Services for the Modern Web and Mobile Applications"
                        },
                         new Topic
                        {
                            Title = "The Lean Enterprise"
                        }
                    }
                },
                new Session
                {
                    Speaker = new Speaker {Name = "David Harry"},
                    Timeslot = "09:00 - 10:00",
                    Title = "DevOps",
                    Topics = new List<Topic>
                    {
                        new Topic
                        {
                            Title = "Building durable Pipeline"
                        }
                    }
                },
            };
        }
    }
}
