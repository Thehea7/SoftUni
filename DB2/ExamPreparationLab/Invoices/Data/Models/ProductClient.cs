using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Data.Models
{
    public class ProductClient
    {
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))] 
        public virtual Product Product { get; set; } = null!;

        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; } = null!;
    }
}
