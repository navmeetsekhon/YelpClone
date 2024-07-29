namespace Yelp.Entities
{
    public class Business
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid CityId { get; set; }
        public string BusinessTypeId { get; set; }
        public string Details { get; set; }
        public string Website { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public DateTime CreatedOn { get; set; }

        public Business(
            string name,
            string address,
            Guid cityId,
            string businessTypeId,
            string details,
            string website,
            DateTime openingTime,
            DateTime closingTime
        )
        {
            Id = Guid.NewGuid(); // Generating a new Guid for Id
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            CityId = cityId != Guid.Empty ? cityId : throw new ArgumentException("CityId cannot be empty", nameof(cityId));
            BusinessTypeId = businessTypeId ?? throw new ArgumentNullException(nameof(businessTypeId));
            Details = details ?? throw new ArgumentNullException(nameof(details));
            Website = website ?? throw new ArgumentNullException(nameof(website));
            OpeningTime = openingTime;
            ClosingTime = closingTime;
            CreatedOn = DateTime.UtcNow;
        }

    }
}
