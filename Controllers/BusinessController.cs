using Microsoft.AspNetCore.Mvc;
using Yelp.Entities.BusinessEntities;
using Yelp.Services;

namespace Yelp.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase{
        private readonly IBusinessService businessService;
        public BusinessController(IBusinessService businessService){
            this.businessService = businessService;
        }
        [HttpGet("all")]
        public ActionResult<IEnumerable<Business>> GetAllBusinesses() {
            return new ActionResult<IEnumerable<Business>>(businessService.GetAll());
        }
        [HttpPost]
        public ActionResult<Business> AddBusiness(Business newBusiness){
            return new ActionResult<Business>(businessService.AddBusiness(newBusiness));
        }
        [HttpPut("{businessId}")]
        public ActionResult<Business> UpdateBusiness(Guid businessId, Business business){
            return new ActionResult<Business>(businessService.UpdateBusiness(business));
        }
        [HttpPost("exists")]
        public ActionResult<bool> IsExisting(Business business){
            return new ActionResult<bool>(businessService.Exists(business));
        }
        [HttpGet("{businessId}")]
        public ActionResult<Business> FindBusiness(Guid businessId){
            return new ActionResult<Business>(businessService.FindBusiness(businessId));
        }
        [HttpDelete("{businessId}")]
        public ActionResult<Business> DeleteBusiness(Guid businessId){
            return new ActionResult<Business>(businessService.DeleteBusiness(businessId));
        }
    }
}