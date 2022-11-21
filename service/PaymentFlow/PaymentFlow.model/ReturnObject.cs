using Newtonsoft.Json;
using System.Net;

namespace PaymentFlow.model
{
    public class ReturnObject
    {
        [JsonProperty("responsecode")]
        public HttpStatusCode ResponseCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("response")]
        public dynamic Response { get; set; }
    }
}
