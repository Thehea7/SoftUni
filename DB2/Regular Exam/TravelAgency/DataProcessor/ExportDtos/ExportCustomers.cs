using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.Data;

namespace TravelAgency.DataProcessor.ExportDtos
{
    public class ExportCustomers
    {
       public string FullName { get; set; }

       public string PhoneNumber { get; set; }

       public ICollection<ExportBookings> Bookings { get; set; } = new List<ExportBookings>();
    }

    public class ExportBookings
    {
        public string TourPackageName { get; set; }
        public string Date { get; set;}
    }
}


