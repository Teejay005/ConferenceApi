namespace ConferenceApi.Interfaces
{
    public interface IValidationService
    {
        public bool ValidateRequestParameters(string speakerName, string date, string timeslot);
    }
}
