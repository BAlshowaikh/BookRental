using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Return Records")]
    public partial class ReturnRecord
    {
        public ReturnRecord()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        [Key]
        [Column("recordId")]
        [Display(Name = "Record ID")]
        public int RecordId { get; set; }
        [Column("expectedReturnDate", TypeName = "datetime")]
        [Display(Name = "Expected Return Date")]
        public DateTime ExpectedReturnDate { get; set; }
        [Column("actualReturnDate", TypeName = "datetime")]
        [Display(Name = "Actual Return Date")]
        public DateTime ActualReturnDate { get; set; }
        [Column("totalAdditionalCharges")]
        [Display(Name = "Total Additional Charges")]
        public double TotalAdditionalCharges { get; set; }
        [Column("lateReturnFee")]
        [Display(Name = "Late Return Fee")]
        public double LateReturnFee { get; set; }
        [Column("bookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        [Column("bookConditionId")]
        [Display(Name = "Book Condition ID")]
        public int BookConditionId { get; set; }
        [Column("transactionId")]
        [Display(Name = "Transaction ID")]
        public int TransactionId { get; set; }
        [Column("extraChargesId")]
        [Display(Name = "Extra Charges ID")]
        public int? ExtraChargesId { get; set; }

        [ForeignKey("BookId")]
        [InverseProperty("ReturnRecords")]
        public virtual Book Book { get; set; }
        [ForeignKey("BookConditionId")]
        [InverseProperty("ReturnRecords")]
        public virtual BookCondition BookCondition { get; set; }
        [ForeignKey("ExtraChargesId")]
        [InverseProperty("ReturnRecords")]
        public virtual ExtraCharge ExtraCharges { get; set; }
        [ForeignKey("TransactionId")]
        [InverseProperty("ReturnRecords")]
        public virtual RentalTransaction Transaction { get; set; }
        [InverseProperty("ReturnRecord")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
