using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class MemberModel
    {
        [Key]
        public Guid IdMember { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(250, ErrorMessage = "Name field may only contain up to 250 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(100, ErrorMessage = "Title field may only contain up to 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(250, ErrorMessage = "Position field may only contain up to 250 characters")]
        public string Position { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(1000, ErrorMessage = "Description field may only contain up to 1000 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public string Resume { get; set; }
    }
}