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
        [Display(Name = "Feedback ID")]
        public int FeedbackId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Column("comment")]
        [StringLength(100)]
        public string Comment { get; set; }
        [Column("rate")]
        public int Rate { get; set; }
        [Column("bookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        [Column("isHidden")]
        [Display(Name = "Is Hidden?")]
        public bool IsHidden { get; set; }
        [Column("returnRecordId")]
        [Display(Name = "Return Record ID")]
        public int? ReturnRecordId { get; set; }

        [ForeignKey("BookId")]
        [InverseProperty("Feedbacks")]
        public virtual Book Book { get; set; }
        [ForeignKey("ReturnRecordId")]
        [InverseProperty("Feedbacks")]
        public virtual ReturnRecord ReturnRecord { get; set; }
    }
}
