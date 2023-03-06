using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class DonationModel
    {
        [Key]
        public Guid IdDonation { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public Guid IdMember { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public string CurrencyType { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        public DateTime DateTimeDonated { get; set; }



    }
}
