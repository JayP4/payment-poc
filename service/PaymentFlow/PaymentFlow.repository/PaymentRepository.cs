using PaymentFlow.model;

namespace PaymentFlow.repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public async Task<Receipt> GetReceiptById(int id)
        {
            return new Receipt
            {
                Id = 1,
                SiteName = "Site A",
                Address = "814 Cox Views",
                City = "Lake Teaganshire",
                Country = "BS6 9HE",
                Date = DateTime.Now.ToShortDateString(),
                PostalCode = "",
                Region = "EU"
            };
        }

        public async Task<Site> GetSiteByName(string name)
        {
            var data = SiteData.SiteList();
            var result = data.FirstOrDefault(s => s.Name == name);
            return result;
        }

        public async Task<List<Site>> GetSites()
        {
            return SiteData.SiteList();
        }
    }
}
