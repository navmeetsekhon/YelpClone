using System.ComponentModel.DataAnnotations;

namespace Yelp.Entities.BusinessEntities{
    public class City(string CityName, string State)
    {
        [Key]
        public Guid CityId { get; set; } 
            = new Guid();
        [Required]
        public string CityName { get; set; } 
            = CityName ?? throw new ArgumentNullException(nameof(CityName));
        [Required]
        public string State { get; set; } 
            = State ?? throw new ArgumentNullException(nameof(State));
    }
}