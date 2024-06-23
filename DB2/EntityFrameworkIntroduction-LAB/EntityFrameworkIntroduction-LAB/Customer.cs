using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Keyless]
    public partial class Customer
    {
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(16)]
        [Unicode(false)]
        public string PaymentNumber { get; set; } = null!;
    }
}
