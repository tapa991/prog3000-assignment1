using System.ComponentModel.DataAnnotations;

namespace PatrickT_Assignment1.Models
{
    public enum UserRole
    {
        Student,
        Professor
    }

    public enum Equipment
    {
        Laptop,
        Phone,
        Tablet,
        Another
    }

    public class EquipmentRequest
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string? PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public Equipment EquipmentType { get; set; }
        [Required(ErrorMessage = "Please enter request details")]
        public string? RequestDetails { get; set; }
        [Required(ErrorMessage = "Please enter the duration")]
        public int? Duration { get; set; }

    }
}
