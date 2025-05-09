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
        public int RecordId { get; set; }
        [Column("expectedReturnDate", TypeName = "datetime")]
        public DateTime ExpectedReturnDate { get; set; }
        [Column("actualReturnDate", TypeName = "datetime")]
        public DateTime ActualReturnDate { get; set; }
        [Column("totalAdditionalCharges")]
        public double TotalAdditionalCharges { get; set; }
        [Column("lateReturnFee")]
        public double LateReturnFee { get; set; }
        [Column("bookId")]
        public int BookId { get; set; }
        [Column("bookConditionId")]
        public int BookConditionId { get; set; }
        [Column("transactionId")]
        public int TransactionId { get; set; }
        [Column("extraChargesId")]
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
