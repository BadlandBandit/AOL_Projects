using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models;

public class InsureeMetadata
{
    [DisplayName("First Name")]
    [Required(ErrorMessage = "First name is required.")]
    public string FirstName { get; set; } = string.Empty;

    [DisplayName("Last Name")]
    [Required(ErrorMessage = "Last name is required.")]
    public string LastName { get; set; } = string.Empty;

    [DisplayName("Email Address")]
    [Required(ErrorMessage = "Email address is required.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string EmailAddress { get; set; } = string.Empty;

    [DisplayName("Date of Birth")]
    [Required(ErrorMessage = "Date of birth is required.")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    [DisplayName("Car Year")]
    [Range(1900, 2100, ErrorMessage = "Car year must be between 1900 and 2100.")]
    public int CarYear { get; set; }

    [DisplayName("Car Make")]
    [Required(ErrorMessage = "Car make is required.")]
    public string CarMake { get; set; } = string.Empty;

    [DisplayName("Car Model")]
    [Required(ErrorMessage = "Car model is required.")]
    public string CarModel { get; set; } = string.Empty;

    [DisplayName("DUI")]
    public bool DUI { get; set; }

    [DisplayName("Speeding Tickets")]
    [Range(0, 100, ErrorMessage = "Speeding tickets cannot be negative.")]
    public int SpeedingTickets { get; set; }

    [DisplayName("Full Coverage")]
    public bool CoverageType { get; set; }

    [DisplayName("Monthly Quote")]
    [DataType(DataType.Currency)]
    public decimal Quote { get; set; }
}
