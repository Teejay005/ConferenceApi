using Microsoft.VisualBasic;
using System;

namespace ConferenceApi.Controllers
{
    public class Session
    {
        public Speaker Speaker { get; set; }
        public string Title { get; set; }
        public DateTime Timeslot { get; set; }
    }
}