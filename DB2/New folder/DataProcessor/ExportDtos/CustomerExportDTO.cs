namespace TravelAgency.DataProcessor.ExportDtos
{
    public class CustomerExportDTO
    {
        public string FullName { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;

        public BookingExportDTO[] Bookings { get; set; } = default!;
    }
}
