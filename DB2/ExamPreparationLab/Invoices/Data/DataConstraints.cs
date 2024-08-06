using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Data
{
    public static class DataConstraints
    {

        //Product
        public const byte ProductNameMinLength = 9;
        public const byte ProductNameMaxLength = 30;
        public const string ProductPriceMinValue = "5.00";
        public const string ProductPriceMaxValue = "1000.00";
        public const int ProductCategoryTypeMin = 0;
        public const int ProductCategoryTypeMax = 4;

        //Address

        public const byte StreetNameMinLength = 10;
        public const byte StreetNameMaxLength = 20;
        public const byte CityMinLength = 5;
        public const byte CityMaxLength = 15;
        public const byte CountryMinLength = 5;
        public const byte CountryMaxLength = 15;

        //Invoice

        public const int InvoiceNumberMinValue = 1_000_000_000;
        public const int InvoiceNumberMaxValue = 1_500_000_000;
        public const int InvoiceCurrencyTypeMinValue = 0;
        public const int InvoiceCurrencyTypeMaxValue = 2;

        //Client

        public const byte ClientNameMin = 10;
        public const byte ClientNameMax = 25;
        public const byte ClientNumberVatMin = 10;
        public const byte ClientNumberVatMax = 15;

    }
}
