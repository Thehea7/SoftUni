using System.Globalization;
using Invoices.DataProcessor.ExportDto;
using Invoices.Utilities;

namespace Invoices.DataProcessor
{
    using Invoices.Data;

    public class Serializer
    {
        public static string ExportClientsWithTheirInvoices(InvoicesContext context, DateTime date)
        {
            XmlHelper xmlHelper = new XmlHelper();

            const string xmlRoot = "Clients";

            var clientsToExport = context.Clients
                .Where(c => c.Invoices.Any(i => i.IssueDate > date))
                .Select(c => new ExportClientDto()
                {
                    ClientName = c.Name,
                    VatNumber = c.NumberVat,
                    Invoices = c.Invoices
                        .OrderBy(i => i.IssueDate)
                        .ThenByDescending(i => i.DueDate)
                        .Select(i => new ExportClientInvoiceDto()
                        {
                            InvoiceNumber = i.Number,
                            InvoiceAmount = i.Amount,
                            Currency = i.CurrencyType.ToString(),
                            DueDate = i.DueDate.ToString("d", CultureInfo.InvariantCulture)

                        })
                        .ToArray(),
                    InvoicesCount = c.Invoices.Count()
                })
                .OrderByDescending(c => c.InvoicesCount)
                .ThenBy(c => c.ClientName)
                .ToArray();

            return xmlHelper.Serialize(clientsToExport, xmlRoot);
        }

        public static string ExportProductsWithMostClients(InvoicesContext context, int nameLength)
        {

            throw new NotImplementedException();
        }
    }
}