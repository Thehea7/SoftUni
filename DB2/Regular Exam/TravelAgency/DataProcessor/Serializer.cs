using Newtonsoft.Json;
using TravelAgency.Data;
using TravelAgency.DataProcessor.ExportDtos;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            throw new NotImplementedException();
        }

        public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            var cutomers = context.Customers
                .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
                .Select(c => new
                {
                    c.FullName,
                    c.PhoneNumber,
                    Bookings = c.Bookings
                        .Select(b => new
                        {
                            TourPackageName = b.TourPackage.PackageName,
                            Date = b.BookingDate
                        })
                        .AsEnumerable()
                        .OrderBy(b => b.Date),


                })
                .OrderByDescending(c => c.Bookings.Count())
                .ThenBy(c => c.FullName)
                .ToList();

            var result = new List<ExportCustomers>();

            foreach (var cutomer in cutomers)
            {
                ExportCustomers newCustomer = new ExportCustomers();

                newCustomer.FullName = cutomer.FullName;
                newCustomer.PhoneNumber = cutomer.PhoneNumber;
                   foreach (var booking in cutomer.Bookings)
                {
                    ExportBookings newBooking = new ExportBookings()
                    {
                        TourPackageName = booking.TourPackageName,
                        Date = booking.Date.ToString("yyyy-MM-dd")
                    };
                    newCustomer.Bookings.Add(newBooking);
                }
                result.Add(newCustomer);
            }
            
            return JsonConvert.SerializeObject(result);
        }
    }
}
