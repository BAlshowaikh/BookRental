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
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("transactionId")]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }
        [Column("bookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        [Column("userId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Column("rentalStartDate", TypeName = "datetime")]
        [Display(Name = "Start Date")]
        public DateTime RentalStartDate { get; set; }
        [Column("returnDate", TypeName = "datetime")]
        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }
        [Column("rentalFee")]
        [Display(Name = "Rental Fee")]
        public double RentalFee { get; set; }
        [Column("paymentMethodId")]
        [Display(Name = "Payment Method ID")]
        public int PaymentMethodId { get; set; }
        [Column("paymentStatusId")]
        [Display(Name = "Payment Status ID")]
        public int PaymentStatusId { get; set; }
        [Column("rentalPeriod")]
        [Display(Name = "Rental Period")]
        public int RentalPeriod { get; set; }
        [Column("isReturned")]
        [Display(Name = "Is Returned?")]
        public bool IsReturned { get; set; }
        [Column("rentalRequestId")]
        [Display(Name = "Request ID")]
        public int RentalRequestId { get; set; }

        [ForeignKey("BookId")]
        [InverseProperty("RentalTransactions")]
        public virtual Book Book { get; set; }
        [ForeignKey("PaymentMethodId")]
        [InverseProperty("RentalTransactions")]
        public virtual PaymentMethod PaymentMethod { get; set; }
        [ForeignKey("PaymentStatusId")]
        [InverseProperty("RentalTransactions")]
        public virtual PaymentStatus PaymentStatus { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("RentalTransactions")]
        public virtual User User { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
