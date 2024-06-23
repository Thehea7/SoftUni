using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction_LAB
{
    public partial class WizzardDeposit
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string? LastName { get; set; }
        [Column(TypeName = "text")]
        public string? Notes { get; set; }
        public int? Age { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? MagicWandCreator { get; set; }
        public short? MagicWandSize { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? DepositGroup { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DepositStartDate { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? DepositAmount { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? DepositInterest { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? DepositCharge { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DepositExpirationDate { get; set; }
        public bool? IsDepositExpired { get; set; }
    }
}
