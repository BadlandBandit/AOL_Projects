using Microsoft.AspNetCore.Mvc;

namespace CarInsurance.Models;

[ModelMetadataType(typeof(InsureeMetadata))]
public class Insuree
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public int CarYear { get; set; }

    public string CarMake { get; set; } = string.Empty;

    public string CarModel { get; set; } = string.Empty;

    public bool DUI { get; set; }

    public int SpeedingTickets { get; set; }

    // false = liability, true = full coverage
    public bool CoverageType { get; set; }

    public decimal Quote { get; set; }
}
