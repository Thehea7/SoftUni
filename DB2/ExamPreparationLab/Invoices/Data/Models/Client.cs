using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Invoices.Data.DataConstraints;

namespace Invoices.Data.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ClientNameMax)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ClientNumberVatMax)]
        public string NumberVat { get; set; } = null!;

        public virtual ICollection<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Invoice> Invoices { get; set; } = new HashSet<Invoice>();


    }
}
