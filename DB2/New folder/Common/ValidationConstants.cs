namespace TravelAgency.Common
{
    public class ValidationConstants
    {
        public const int NameMaxLength = 60;
        public const int NameMinLength = 4;

        public const int CustomerEmailMaxLength = 50;
        public const int CustomerEmailMinLength = 6;

        public const int PackageNameMaxLength = 40;
        public const int PackageNameMinLength = 2;

        public const int DescriptionMaxLength = 200;

        public const string CustomerPhoneNumberPattern = @"^\+\d{12}$";
    }
}
