using System;
using System.Runtime.Serialization;

namespace ConferenceApi.Controllers
{
    [Serializable]
    public class ConferenceAPIException : Exception
    {
        public ConferenceAPIException()
        {
        }

        public ConferenceAPIException(string message) : base(message)
        {
        }

        public ConferenceAPIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConferenceAPIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}