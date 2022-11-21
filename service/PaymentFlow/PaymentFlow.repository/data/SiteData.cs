using PaymentFlow.model;

namespace PaymentFlow.repository
{
    public static class SiteData
    {
        public static List<Site> SiteList()
        {
            List<Site> list = new List<Site>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(new Site { Id = i, Name = "Site " + i, Description = "Description of Site " + i });
            }
            return list;
        }
    }
}
