using System.Collections;
using System.Globalization;
using System.Text;
using Invoices.Data.Models;
using Invoices.Data.Models.Enums;
using Invoices.DataProcessor.ImportDto;
using Invoices.Utilities;
using Newtonsoft.Json;

namespace Invoices.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using Invoices.Data;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedClients
            = "Successfully imported client {0}.";

        private const string SuccessfullyImportedInvoices
            = "Successfully imported invoice with number {0}.";

        private const string SuccessfullyImportedProducts
            = "Successfully imported product - {0} with {1} clients.";


        public static string ImportClients(InvoicesContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlHelper xmlHelper = new XmlHelper();
            string xmlRoot = "Clients";

            //ValidModelToImportIntoTheDB
            ICollection<Client> clientsToImport = new HashSet<Client>();

            ImportClientDto[] deserializedClients = xmlHelper.Deserialize<ImportClientDto[]>(xmlString, xmlRoot);

            foreach (ImportClientDto clientDto in deserializedClients)
            {
                if (!IsValid(clientDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                ICollection<Address> addressesToImport = new List<Address>();
                foreach (ImportAddressDto adressDto in clientDto.Addresses)
                {
                    if (!IsValid(adressDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Address newAddress = new Address()
                    {
                        StreetName = adressDto.StreetName,
                        StreetNumber = adressDto.StreetNumber,
                        PostCode = adressDto.PostCode,
                        City = adressDto.City,
                        Country = adressDto.Country
                    };
                    addressesToImport.Add(newAddress);
                }

                Client newClient = new Client()
                {
                    Name = clientDto.Name,
                    NumberVat = clientDto.NumberVat,
                    Addresses = addressesToImport
                };
                clientsToImport.Add(newClient);
                sb.AppendLine(String.Format(SuccessfullyImportedClients, clientDto.Name));
            }

            context.Clients.AddRange(clientsToImport); //EF will Import Both New Clients and New Addresses
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static object Address { get; set; }


        public static string ImportInvoices(InvoicesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Invoice> invoicesToImport = new List<Invoice>();

            importInvoiceDto[] deserializedInvoices = JsonConvert.DeserializeObject<importInvoiceDto[]>(jsonString)!;

            foreach (importInvoiceDto InvoiceDto in deserializedInvoices)
            {
                if (!IsValid(InvoiceDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                bool isIssueDateValid = DateTime.TryParse(InvoiceDto.IssueDate, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime IssueDate);

                bool isDueDateValid = DateTime.TryParse(InvoiceDto.DueDate, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime DueDate);

                if (isIssueDateValid == false || isDueDateValid == false || DateTime.Compare(DueDate, IssueDate) < 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (context.Clients.Any(c => c.Id == InvoiceDto.ClientId) == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Invoice invoice = new Invoice()
                {
                    Number = InvoiceDto.Number,
                    IssueDate = IssueDate,
                    DueDate = DueDate,
                    Amount = InvoiceDto.Amount,
                    CurrencyType = (CurrencyType)InvoiceDto.CurrencyType,
                    ClientId = InvoiceDto.ClientId
                };

                invoicesToImport.Add(invoice);
                sb.AppendLine(String.Format(SuccessfullyImportedInvoices, InvoiceDto.Number));
            }

            context.Invoices.AddRange(invoicesToImport);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportProducts(InvoicesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ICollection<Product> productsToImport = new List<Product>();

            ImportProductDto[] deserializedProducts = JsonConvert.DeserializeObject<ImportProductDto[]>(jsonString)!;

            foreach (var productDto in deserializedProducts)
            {
                if (!IsValid(productDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Product newProduct = new Product()
                {
                    Name = productDto.Name,
                    Price = productDto.Price,
                    CategoryType = (CategoryType)productDto.CategoryType
                };

                ICollection<ProductClient> productClientsToImport = new List<ProductClient>();

                foreach (var clientId in productDto.Clients.Distinct())
                {
                    if (!context.Clients.Any(cl => cl.Id == clientId))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    ProductClient newProductClient = new ProductClient()
                    {
                        ClientId = clientId,
                        Product = newProduct
                    };

                    productClientsToImport.Add(newProductClient);
                }

                newProduct.ProductsClients = productClientsToImport;

                productsToImport.Add(newProduct);
                sb.AppendLine(string.Format(SuccessfullyImportedProducts, productDto.Name,
                    newProduct.ProductsClients.Count));
            }
            context.Products.AddRange(productsToImport);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    } 
}
