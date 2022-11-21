using PaymentFlow.model;

namespace PaymentFlow.service
{
    public interface IPaymentService
    {
        Task<ReturnObject> GetSites();
        Task<ReturnObject> GetSiteByName(string name);
        Task<ReturnObject> GetReceiptById(int id);
    }
}
