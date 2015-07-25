using System.ComponentModel.DataAnnotations;

namespace Nesjartun.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }
    }
}