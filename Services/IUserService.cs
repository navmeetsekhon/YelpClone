using Yelp.Entities.UserEntities;

namespace Yelp.Services
{
    public interface IUserService
    {
        public User AddUser(User newUser);
        public User GetUser(Guid userId);
        public User UpdateUser(Guid userId, User newUser);
        public bool DeleteUser(Guid userId);
    }
}
