using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please add your name and family name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please add an e-mial address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please add a phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you attend")]
        public bool? WillAttend { get; set; }
    }
}
