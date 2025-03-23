using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [Column("feedbackId")]
        public int FeedbackId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Column("comment")]
        [StringLength(100)]
        public string? Comment { get; set; }
        [Column("transactionId")]
        public int TransactionId { get; set; }
        [Column("rate")]
        public int? Rate { get; set; }

        [ForeignKey("TransactionId")]
        [InverseProperty("Feedbacks")]
        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}
