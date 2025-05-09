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
        public int AuditId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("oldValue")]
        [StringLength(100)]
        public string OldValue { get; set; }
        [Required]
        [Column("newValue")]
        [StringLength(100)]
        public string NewValue { get; set; }
        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AuditTrails")]
        public virtual User User { get; set; }
    }
}
