using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Extra Charges")]
    public partial class ExtraCharge
    {
        [Key]
        [Column("extraChargesId")]
        public int ExtraChargesId { get; set; }
        [Column("extra_charge_name")]
        [StringLength(20)]
        public string ExtraChargeName { get; set; } = null!;
        [Column("Extra_charge_rate")]
        public double ExtraChargeRate { get; set; }
        [Column("recordId")]
        public int? RecordId { get; set; }

        [ForeignKey("RecordId")]
        [InverseProperty("ExtraCharges")]
        public virtual ReturnRecord? Record { get; set; }
    }
}
