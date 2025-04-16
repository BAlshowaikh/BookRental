using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Rental Transaction")]
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            Feedbacks = new HashSet<Feedback>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("transactionId")]
        public int TransactionId { get; set; }
        [Column("bookId")]
        public int BookId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("rentalStartDate", TypeName = "datetime")]
        public DateTime? RentalStartDate { get; set; }
        [Column("returnDate", TypeName = "datetime")]
        public DateTime? ReturnDate { get; set; }
        [Column("rentalFee")]
        public double? RentalFee { get; set; }
        [Column("paymentMethodId")]
        public int PaymentMethodId { get; set; }
        [Column("paymentStatusId")]
        public int PaymentStatusId { get; set; }
        [Column("rentalPeriod")]
        [StringLength(50)]
        public string? RentalPeriod { get; set; }

        [ForeignKey("BookId")]
        [InverseProperty("RentalTransactions")]
        public virtual Book Book { get; set; } = null!;
        [ForeignKey("PaymentMethodId")]
        [InverseProperty("RentalTransactions")]
        public virtual PaymentMethod PaymentMethod { get; set; } = null!;
        [ForeignKey("PaymentStatusId")]
        [InverseProperty("RentalTransactions")]
        public virtual PaymentStatus PaymentStatus { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalTransactions")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Transaction")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
