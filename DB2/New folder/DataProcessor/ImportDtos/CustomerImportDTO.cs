using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using TravelAgency.Common;

namespace TravelAgency.DataProcessor.ImportDtos
{
    [XmlType("Customer")]
    public class CustomerImportDTO
    {
        [XmlElement("FullName")]
        [Required]
        [StringLength(ValidationConstants.NameMaxLength, MinimumLength = ValidationConstants.NameMinLength)]
        public string FullName { get; set; } = default!;

        [XmlElement("Email")]
        [Required]
        [StringLength(ValidationConstants.CustomerEmailMaxLength, MinimumLength = ValidationConstants.CustomerEmailMinLength)]
        public string Email { get; set; } = default!;

        [XmlAttribute("phoneNumber")]
        [Required]
        [RegularExpression(ValidationConstants.CustomerPhoneNumberPattern)]
        public string PhoneNumber { get; set; } = default!;
    }
}
