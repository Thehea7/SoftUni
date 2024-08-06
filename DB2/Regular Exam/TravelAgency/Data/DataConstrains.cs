using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.Data
{
    public static class DataConstrains
    {
        // Guide Constrains

        public const byte GuideFullNameMin = 4;
        public const byte GuideFullNameMax = 60;


        //•	PackageName Constrains

        public const byte PackageNameMin = 2;
        public const byte PackageNameMax = 40;

        public const byte PackageDescriptionMax = 200;

        public const byte PackagePriceMinValue = 0;

        // Customer

        public const byte CustomerFullNameMin = 4;
        public const byte CustomerFullNameMax = 60;

        public const byte CustomerEmailMin = 6;
        public const byte CustomerEmailMax = 50;

        public const byte CustomerPhoneNumberMax = 13;
    }
}
