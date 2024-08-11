using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Yelp.Entities.BusinessEntities
{
    public class BusinessPhoto(Business Business, byte[] Photo, string? Caption)
    {
        [Key]
        public Guid Id { get; set; } 
            = new Guid();
        [ForeignKey("BusinessId")]
        public Business Business { get; set; } 
            = Business ?? throw new ArgumentNullException(nameof(Business));
        [Required]
        [Column(TypeName = "VARBINARY(MAX)")]
        public byte[] Photo { get; set; } 
            = Photo ?? throw new ArgumentNullException(nameof(Photo));
        public string? Caption { get; set; } 
            = Caption;
        [Required]
        public DateTime UploadedOn { get; set; } 
            = DateTime.UtcNow;
    }
}