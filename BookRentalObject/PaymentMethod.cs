using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Payment Method")]
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("paymentMethodId")]
        public int PaymentMethodId { get; set; }
        [Column("paymentMethod")]
        [StringLength(50)]
        public string? PaymentMethod1 { get; set; }

        [InverseProperty("PaymentMethod")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
