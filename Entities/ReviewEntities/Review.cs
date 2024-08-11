using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;
using Yelp.Entities.BusinessEntities;
using Yelp.Entities.UserEntities;
namespace Yelp.Entities.ReviewEntities{
    public class Review
    {
        [Key]
        public Guid Id { get; }

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Required]
        public Guid BusinessId { get; set; }

        [ForeignKey("BusinessId")]
        public Business? Business { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        public int Upvotes { get; set; }

        public int Downvotes { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public Review(
            Guid userId,
            Guid businessId,
            int rating,
            string comment = "",
            int upvotes = 0,
            int downvotes = 0
        )
        {
            if (userId == Guid.Empty) throw new ArgumentNullException(nameof(userId));
            if (businessId == Guid.Empty) throw new ArgumentNullException(nameof(businessId));
            if (rating < 1 || rating > 5) throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 1 and 5");

            Id = Guid.NewGuid();
            UserId = userId;
            BusinessId = businessId;
            Rating = rating;
            Comment = comment;
            Upvotes = upvotes;
            Downvotes = downvotes;
            CreatedOn = DateTime.UtcNow;
        }
    }
}