using Yelp.Entities.BusinessEntities;

namespace Yelp.Services{
    public interface IBusinessService{
        public IEnumerable<Business> GetAll();
        public Business AddBusiness(Business business);
        public Business UpdateBusiness(Business UpdatedBusiness);
        public bool Exists(Business business);
        public Business FindBusiness(Guid id);
        public Business DeleteBusiness(Guid businessId);
    }
}