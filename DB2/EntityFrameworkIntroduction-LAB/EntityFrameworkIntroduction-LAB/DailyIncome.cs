using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    [Keyless]
    [Table("DailyIncome")]
    public partial class DailyIncome
    {
        [StringLength(10)]
        public string? VendorId { get; set; }
        [StringLength(10)]
        public string? IncomeDay { get; set; }
        public int? IncomeAmount { get; set; }
    }
}
