using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Audit Trails")]
    public partial class AuditTrail
    {
        [Key]
        [Column("auditId")]
        [Display(Name = "Audit ID")]
        public int AuditId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("oldValue")]
        [StringLength(100)]
        [Display(Name = "Old Value")]
        public string OldValue { get; set; }
        [Required]
        [Column("newValue")]
        [StringLength(100)]
        [Display(Name = "New Value")]
        public string NewValue { get; set; }
        [Column("userId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AuditTrails")]
        public virtual User User { get; set; }
    }
}
