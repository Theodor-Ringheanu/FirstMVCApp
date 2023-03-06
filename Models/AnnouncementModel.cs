using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class AnnouncementModel
    {
        [Key]
        public Guid IdAnnouncement { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(250, ErrorMessage = "Title camp may only contain a maximum of 250 characters")]
        public DateTime ValidFrom { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        public DateTime ValidTo { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        public string Title { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(250, ErrorMessage = "Text camp may only contain a maximum of 250 characters")]
        public string Text { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        public DateTime EventDate { get; set;}

        [Required(ErrorMessage = "This field is mandatory")]
        [StringLength(1000, ErrorMessage = "Tags camp may only contain a maximum of 1000 characters")]
        public string Tags { get; set;}
    }
}
