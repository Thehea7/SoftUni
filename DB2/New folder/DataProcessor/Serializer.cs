using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Serialization;
using TravelAgency.Data;
using TravelAgency.DataProcessor.ExportDtos;

namespace TravelAgency.DataProcessor
{
    public class Serializer
    {
        public static string ExportGuidesWithSpanishLanguageWithAllTheirTourPackages(TravelAgencyContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();

            XmlSerializer serializer = new XmlSerializer(typeof(GuideExportDTO[]), new XmlRootAttribute("Guides"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using StringWriter writer = new StringWriter(stringBuilder);

            GuideExportDTO[] guidesToExport = context.Guides
                .Where(g => g.Language == Data.Models.Enums.Language.Spanish)
                .Include(g => g.TourPackagesGuides)
                .ThenInclude(tpg => tpg.TourPackage)
                .Select(g => new GuideExportDTO
                {
                    FullName = g.FullName,
                    TourPackages = g.TourPackagesGuides
                        .Select(tpg => new TourPackageExportDTO
                        {
                            TourPackageName = tpg.TourPackage.PackageName,
                            Description = tpg.TourPackage.Description,
                            Price = tpg.TourPackage.Price
                        })
                        .OrderByDescending(tp => tp.Price)
                        .ToArray()
                })
                .OrderByDescending(g => g.TourPackages.Count())
                .ThenBy(g => g.FullName)
                .ToArray();

            serializer.Serialize(writer, guidesToExport, namespaces);
            return stringBuilder.ToString().TrimEnd();
        }

        public static string ExportCustomersThatHaveBookedHorseRidingTourPackage(TravelAgencyContext context)
        {
            var customersData = context.Customers
            .Where(c => c.Bookings.Any(b => b.TourPackage.PackageName == "Horse Riding Tour"))
            .Select(c => new
            {
                c.FullName,
                c.PhoneNumber,
                Bookings = c.Bookings
                    .Where(b => b.TourPackage.PackageName == "Horse Riding Tour")
                    .Select(b => new
                    {
                        b.TourPackage.PackageName,
                        b.BookingDate
                    })
                    .OrderBy(b => b.BookingDate)
                    .ToArray()
            })
            .OrderBy(c => c.FullName)
            .ThenBy(c => c.Bookings.Length)
            .ToArray();

            var customersToExport = customersData
                .Select(c => new CustomerExportDTO
                {
                    FullName = c.FullName,
                    PhoneNumber = c.PhoneNumber,
                    Bookings = c.Bookings
                        .Select(b => new BookingExportDTO
                        {
                            TourPackageName = b.PackageName,
                            Date = b.BookingDate.ToString("yyyy-MM-dd")
                        })
                        .ToArray()
                })
                .ToArray();

            return JsonConvert.SerializeObject(customersToExport, Formatting.Indented);
        }
    }
}
