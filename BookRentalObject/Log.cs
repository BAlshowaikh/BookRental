using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Log")]
    public partial class Log
    {
        [Key]
        [Column("logId")]
        public int LogId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime? Timestamp { get; set; }
        [Column("affectedData")]
        [StringLength(100)]
        public string? AffectedData { get; set; }
        [Column("source")]
        [StringLength(100)]
        public string? Source { get; set; }
        [Column("exceptions")]
        [StringLength(100)]
        public string? Exceptions { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; } = null!;
    }
}
