using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class MembershipTypeModel
    {
        [Key]
        public Guid IdMembershipType { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set;}
        [Required(ErrorMessage = "This field is mandatory")]
        public string Description { get; set;}
        [Required(ErrorMessage = "This field is mandatory")]
        public int SubscriptionLengthInMonths { get; set;}
    }
}
