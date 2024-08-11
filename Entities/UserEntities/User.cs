using System.ComponentModel.DataAnnotations;

namespace Yelp.Entities.UserEntities
{
    public class User(
        string FirstName,
        string LastName,
        string EmailAddress,
        string Phone
        )
    {
        [Key]
        public Guid Id { get; set; } 
            = new Guid();

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } 
            = FirstName ?? throw new ArgumentNullException(nameof(FirstName));

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } 
            = LastName ?? throw new ArgumentNullException(nameof(LastName));

        [Required]
        [EmailAddress]
        public string Email { get; set; }
            = EmailAddress ?? throw new ArgumentNullException(nameof(Email));

        [Phone]
        public string Phone { get; set; }
            = Phone ?? throw new ArgumentNullException(nameof(Phone));

        [Required]
        public DateTime CreatedOn { get; set; } 
            = DateTime.UtcNow;
    }
}