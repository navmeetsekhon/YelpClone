using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yelp.Entities.BusinessEntities
{
    public class Business(
        string name,
        string address,
        City city,
        BusinessType businessType,
        string details,
        string website,
        TimeSpan? openingTime = null,
        TimeSpan? closingTime = null
        )
    {
        [Key]
        public Guid Id { get; } 
            = Guid.NewGuid(); // Generating a new Guid for Id

        [Required]
        public string Name { get; set; } 
            = name ?? throw new ArgumentNullException(nameof(name));

        [Required]
        public string Address { get; set; } 
            = address ?? throw new ArgumentNullException(nameof(address));

        [Required]
        public Guid CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; } 
            = city ?? throw new ArgumentException("CityId cannot be empty", nameof(city));

        [Required]
        public Guid BusinessTypeId { get; set; }

        [ForeignKey("BusinessTypeId")]
        public BusinessType BusinessType { get; set; } 
            = businessType ?? throw new ArgumentNullException(nameof(businessType));

        [Required]
        public string Details { get; set; } 
            = details ?? throw new ArgumentNullException(nameof(details));

        [Required]
        [Url]
        public string Website { get; set; } 
            = website ?? throw new ArgumentNullException(nameof(website));

        [Required]
        public TimeSpan OpeningTime { get; set; } 
            = openingTime ?? new TimeSpan(9, 0, 0);

        [Required]
        public TimeSpan ClosingTime { get; set; } 
            = closingTime ?? new TimeSpan(21, 0, 0);
            
        [Required]
        public DateTime CreatedOn { get; set; } 
            = DateTime.UtcNow;
    }
}
