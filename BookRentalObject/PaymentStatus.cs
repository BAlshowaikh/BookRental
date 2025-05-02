using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Payment Status")]
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("paymentId")]
        public int PaymentId { get; set; }
        [Column("paymentStatus")]
        [StringLength(50)]
        public string PaymentStatus1 { get; set; } = null!;

        [InverseProperty("PaymentStatus")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
