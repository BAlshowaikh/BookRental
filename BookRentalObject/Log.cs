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
        [Display(Name = "Log ID")]
        public int LogId { get; set; }
        [Column("userId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("affectedData")]
        [StringLength(100)]
        [Display(Name = "Affected Data")]
        public string AffectedData { get; set; }
        [Required]
        [Column("source")]
        [StringLength(100)]
        public string Source { get; set; }
        [Required]
        [Column("exceptions")]
        [StringLength(100)]
        public string Exceptions { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; }

    }
}
