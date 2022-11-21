using Newtonsoft.Json;
using System.Net;

namespace PaymentFlow.api.Response
{
    public class BaseResponse
    {
        [JsonProperty("responsecode")]
        public HttpStatusCode ResponseCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("callstarttime")]
        public string CallStartTime { get; set; }
        [JsonProperty("callendtime")]
        public string CallEndTime { get; set; }

        private readonly string _dateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

        public BaseResponse()
        {
            CallStartTime = DateTime.UtcNow.ToString(_dateTimeFormat);
        }

        public void Complete()
        {
            CallEndTime = DateTime.UtcNow.ToString(_dateTimeFormat);
        }
    }
}
