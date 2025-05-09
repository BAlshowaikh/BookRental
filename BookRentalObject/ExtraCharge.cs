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
        public ExtraCharge()
        {
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("extraChargesId")]
        [Display(Name = "Extra Charges ID")]
        public int ExtraChargesId { get; set; }
        [Required]
        [Column("extra_charge_name")]
        [StringLength(20)]
        [Display(Name = "Extra Charges Name")]
        public string ExtraChargeName { get; set; }
        [Column("Extra_charge_rate")]
        [Display(Name = "Extra Charges Rate")]
        public double ExtraChargeRate { get; set; }

        [InverseProperty("ExtraCharges")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
