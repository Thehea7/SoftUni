using System.Xml.Serialization;

namespace TravelAgency.DataProcessor.ExportDtos
{
    [XmlType("Guide")]
    public class GuideExportDTO
    {
        [XmlElement("FullName")]
        public string FullName { get; set; } = default!;

        [XmlArray("TourPackages")]
        [XmlArrayItem("TourPackage")]
        public TourPackageExportDTO[] TourPackages { get; set; } = default!;
    }
}
