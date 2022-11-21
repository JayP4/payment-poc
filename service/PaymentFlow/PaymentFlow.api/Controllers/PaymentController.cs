using Microsoft.AspNetCore.Mvc;
using PaymentFlow.api.Response;
using PaymentFlow.model;
using PaymentFlow.service;

namespace PaymentFlow.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        private ApiResponse CreateApiResponse(ReturnObject returnObject)
        {
            var response = new ApiResponse
            {
                Response = returnObject.Response,
                Message = returnObject.Message,
                ResponseCode = returnObject.ResponseCode
            };
            return response;
        }

        [HttpGet]
        public async Task<ApiResponse> GetSites()
        {
            var returnObject = await _paymentService.GetSites();
            var response = CreateApiResponse(returnObject);
            response.Complete();
            return response;
        }

        [HttpGet]
        public async Task<ApiResponse> GetSiteByName(string name)
        {
            var returnObject = await _paymentService.GetSiteByName(name);
            var response = CreateApiResponse(returnObject);
            response.Complete();
            return response;
        }

        [HttpGet]
        public async Task<ApiResponse> GetReceiptById(int id)
        {
            var returnObject = await _paymentService.GetReceiptById(id);
            var response = CreateApiResponse(returnObject);
            response.Complete();
            return response;
        }

        
    }
}
