using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using Newtonsoft.Json;
using TravelAgency.Data;
using TravelAgency.Data.Models.Models;
using TravelAgency.DataProcessor.ImportDtos;
using TravelAgency.Tools;

namespace TravelAgency.DataProcessor
{
    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data format!";
        private const string DuplicationDataMessage = "Error! Data duplicated.";
        private const string SuccessfullyImportedCustomer = "Successfully imported customer - {0}";
        private const string SuccessfullyImportedBooking = "Successfully imported booking. TourPackage: {0}, Date: {1}";

        public static string ImportCustomers(TravelAgencyContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlHelper xmlHelper = new XmlHelper();
            string xmlRoot = "Customers";

            ICollection<Customer> CustomersToImport = new HashSet<Customer>();

            ImportCustomerDto[] deserializedCustomers = xmlHelper.Deserialize<ImportCustomerDto[]>(xmlString, xmlRoot);

            foreach (var customerDto in deserializedCustomers)
            {
                if (!IsValid(customerDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (CustomersToImport.Any(c => c.Email == customerDto.Email)
                    || customerDto.FullName == customerDto.FullName
                    || customerDto.PhoneNumber == customerDto.PhoneNumber)
                {
                    sb.AppendLine(DuplicationDataMessage);
                    continue;
                }

                Customer validCustomer = new Customer()
                {
                    FullName = customerDto.FullName,
                    Email = customerDto.Email,
                    PhoneNumber = customerDto.PhoneNumber
                };
                CustomersToImport.Add(validCustomer);
                sb.AppendLine(String.Format(SuccessfullyImportedCustomer, customerDto.FullName));
            }
            context.Customers.AddRange(CustomersToImport);

            return sb.ToString().TrimEnd();
        }

        public static string ImportBookings(TravelAgencyContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Booking> bookingsToImport = new HashSet<Booking>();

            var cutomers = context.Customers;
            var packages = context.TourPackages;

            ImportBookingDto[] deserializedBookings = JsonConvert.DeserializeObject<ImportBookingDto[]>(jsonString)!;

            foreach (var bookingDto in deserializedBookings)
            {
                if (!IsValid(bookingDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }


                bool isDateValid = DateTime.TryParse(bookingDto.BookingDate, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime BookingDate); //TODO possible date format issue

                if (!isDateValid)
                {
                    sb.AppendLine(ErrorMessage);
                }

                int customerId = cutomers.Where(c => c.FullName == bookingDto.CustomerName).Select(c => c.Id)
                    .FirstOrDefault();
                int tourPackageId = packages.Where(p => p.PackageName == bookingDto.TourPackageName).Select(p => p.Id)
                    .FirstOrDefault();

                Booking booking = new Booking()
                {
                    BookingDate = BookingDate,
                    CustomerId = customerId,
                    TourPackageId = tourPackageId
                };
                

                bookingsToImport.Add(booking);
                sb.AppendLine(String.Format(SuccessfullyImportedBooking, bookingDto.TourPackageName, BookingDate.ToString("yyyy-MM-dd")));

            }

            context.Bookings.AddRange(bookingsToImport);
            context.SaveChanges();


            return sb.ToString().TrimEnd();
        }

        public static bool IsValid(object dto)
        {
            var validateContext = new ValidationContext(dto);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(dto, validateContext, validationResults, true);

            foreach (var validationResult in validationResults)
            {
                string currValidationMessage = validationResult.ErrorMessage;
            }

            return isValid;
        }
    }
}
