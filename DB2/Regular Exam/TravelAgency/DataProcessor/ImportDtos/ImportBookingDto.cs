using System.ComponentModel.DataAnnotations;
using TravelAgency.Data.Models.Models;
using static TravelAgency.Data.DataConstrains;

namespace TravelAgency.DataProcessor.ImportDtos;

public class ImportBookingDto
{
    [Required]
    [DataType("yyyy-MM-dd")]
    public string BookingDate { get; set; } = null!;

    [Required]
    [MinLength(CustomerFullNameMin)]
    [MaxLength(CustomerFullNameMax)]
    public string CustomerName { get; set; } = null!;

    [Required]
    [MinLength(PackageNameMin)]
    [MaxLength(PackageNameMax)]
    public string TourPackageName { get; set; } = null!;
}