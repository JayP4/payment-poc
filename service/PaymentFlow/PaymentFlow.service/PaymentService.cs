using PaymentFlow.model;
using PaymentFlow.repository;

namespace PaymentFlow.service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<ReturnObject> GetReceiptById(int id)
        {
            return new ReturnObject
            {
                Message = "",
                Response = await _paymentRepository.GetReceiptById(id),
                ResponseCode = System.Net.HttpStatusCode.OK
            };
        }

        public async Task<ReturnObject> GetSiteByName(string name)
        {
            return new ReturnObject
            {
                Message = "",
                Response = await _paymentRepository.GetSiteByName(name),
                ResponseCode = System.Net.HttpStatusCode.OK
            };
        }

        public async Task<ReturnObject> GetSites()
        {
            return new ReturnObject
            {
                Message = "",
                Response = await _paymentRepository.GetSites(),
                ResponseCode = System.Net.HttpStatusCode.OK
            };
        }
    }
}