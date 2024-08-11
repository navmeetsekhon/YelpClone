using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yelp.Entities.BusinessEntities{
    public class BusinessService(
        Guid businessId,
        Guid serviceId
    )
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        public Guid BusinessId { get; set; } = businessId;

        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }

        [Required]
        public Guid ServiceId { get; set; } = serviceId;

        [ForeignKey("ServiceId")]
        public Service? Service { get; set; }
    }
}