using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Column(TypeName = "date")]
        public DateTime InvoiceDate { get; set; }
        [Column(TypeName = "numeric(18, 2)")]
        public decimal Total { get; set; }
    }
}
