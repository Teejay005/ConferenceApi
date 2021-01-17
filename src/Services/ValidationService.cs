using ConferenceApi.Interfaces;
using System;

namespace ConferenceApi.Services
{
    public class ValidationService : IValidationService
    {
        public bool ValidateRequestParameters(string speakerName, string date, string timeslot)
        {
            if (string.IsNullOrEmpty(speakerName)) return false;
            if (string.IsNullOrEmpty(date)) return false;
            if (string.IsNullOrEmpty(timeslot)) return false;
            return true;
        }
    }
}
