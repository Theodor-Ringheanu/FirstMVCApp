using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class MembershipModel
    {
        [Key]
        public Guid IdMembership { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public Guid IdMember { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public Guid IdMembershipType { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public int Level { get; set; }
    }
}