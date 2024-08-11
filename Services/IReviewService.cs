using Yelp.Entities.ReviewEntities;

namespace Yelp.Services
{
    public interface IReviewService
    {
        public Review AddReview(Review review);
        public Review GetReview(Guid reviewId);
        public IEnumerable<Review> GetReviews(Guid businessId);
        public Review UpdateReview(Guid reviewId, Review review);
        public bool DeleteReview(Guid reviewId);
    }
}
