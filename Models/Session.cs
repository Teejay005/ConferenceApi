using System;
using System.Collections.Generic;

namespace ConferenceApi.Models
{
    public class Session
    {
        public Speaker Speaker { get; set; }
        public string Title { get; set; }
        public DateTime Timeslot { get; set; }

        public List<Topic> Topics { get; set; } 
    }
}