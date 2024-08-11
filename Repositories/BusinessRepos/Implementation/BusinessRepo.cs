using Yelp.Entities.BusinessEntities;

namespace Yelp.Repositories.BusinessRepos.Implementation
{
    public class BusinessRepo : IBusinessRepo
    {
        private List<Business> Businesses = [];
        public void AddBusiness(Business business) {
            Businesses.Add(business);
        }
        public Business GetBusiness(Guid id) {
            int index = Businesses.FindIndex(b => b.Id == id);
            if (index != -1)
            {
                return Businesses[index];
            }
            else {
                return null;
            }
        }
        public void UpdateBusiness(Business business) {

            int index = Businesses.FindIndex(b => b.Id == business.Id);
            if (index != -1)
            {
                Businesses[index] = business;
            }
        }
        public void DeleteBusiness(Guid id) {
            int index = Businesses.FindIndex(b => b.Id == id);
            if (index != -1)
            {
                Businesses.RemoveAt(index);
            }
        }
    }
}
