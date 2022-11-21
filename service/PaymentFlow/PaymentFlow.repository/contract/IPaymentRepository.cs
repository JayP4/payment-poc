using PaymentFlow.model;

namespace PaymentFlow.repository
{
    public interface IPaymentRepository
    {
        Task<List<Site>> GetSites();
        Task<Site> GetSiteByName(string name);
        Task<Receipt> GetReceiptById(int id);
    }
}
