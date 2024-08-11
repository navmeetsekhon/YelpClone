using System.ComponentModel.DataAnnotations;

namespace Yelp.Entities.BusinessEntities{
    public class BusinessType(string BusinessTypeName){
        [Key]
        public Guid BusinessTypeId {get; set;} 
            = new Guid();
        [Required]
        public string BusinessTypeName {get; set;} 
            = BusinessTypeName;
    }
}