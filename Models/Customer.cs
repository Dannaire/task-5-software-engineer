using System.ComponentModel.DataAnnotations;

namespace Customer_Api.Models
{
    public class Customer
    {
        [Key,Required]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string HomeAddress { get; set; } = string.Empty;
    }
}
