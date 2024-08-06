using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravelAgency.Data.Models.Models;
using static TravelAgency.Data.DataConstrains;

namespace TravelAgency.DataProcessor.ImportDtos
{
    [XmlRoot(nameof(Customer))]
    public class ImportCustomerDto
    {
        [XmlAttribute("phoneNumber")]
        [XmlText]
        [Required]
        //[RegularExpression(@"\\+\\d{12}")]
        public string PhoneNumber { get; set; } = null!;

        [XmlElement(nameof(FullName))]
        [Required]
        [MinLength(CustomerFullNameMin)]
        [MaxLength(CustomerFullNameMax)]
        public string FullName { get; set; } = null!;

        [XmlElement(nameof(Email))]
        [Required]
        [MinLength(CustomerEmailMin)]
        [MaxLength(CustomerEmailMax)]
        public string Email { get; set; } = null!;
    } 
}
