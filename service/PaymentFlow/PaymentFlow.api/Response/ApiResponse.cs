using Newtonsoft.Json;

namespace PaymentFlow.api.Response
{
    public class ApiResponse : BaseResponse
    {
        [JsonProperty("response")]
        public dynamic Response { get; set; }
    }
}
