using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace TravelAgency.DataProcessor.ImportDtos
{
    public class BookingImportDTO
    {
        [Required]
        [JsonProperty("BookingDate")]
        public string BookingDate { get; set; } = default!;

        [Required]
        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; } = default!;

        [Required]
        [JsonProperty("TourPackageName")]
        public string TourPackageName { get; set; } = default!;
    }
}
