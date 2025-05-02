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
        [Column("oldValue")]
        [StringLength(100)]
        public string OldValue { get; set; } = null!;
        [Column("newValue")]
        [StringLength(100)]
        public string NewValue { get; set; } = null!;
        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AuditTrails")]
        public virtual User User { get; set; } = null!;
    }
}
