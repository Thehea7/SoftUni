using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType("TourPackage")]
    public class TourPackageExportDTO
    {
        [XmlElement("Name")]
        public string TourPackageName { get; set; } = default!;

        [XmlElement("Description")]
        public string Description { get; set; } = default!;

        [XmlElement("Price")]
        public decimal Price { get; set; }
    }
}
