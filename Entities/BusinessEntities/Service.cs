using System.ComponentModel.DataAnnotations;

namespace Yelp.Entities.BusinessEntities{
    public class Service(
        string serviceName
    )
    {
        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MaxLength(100)]
        public string ServiceName { get; set; } = serviceName;
    }
}