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
        [Display(Name = "Payment Method ID")]
        public int PaymentMethodId { get; set; }
        [Required]
        [Column("paymentMethod")]
        [StringLength(50)]
        [Display(Name = "Payment Method")]
        public string PaymentMethod1 { get; set; }

        [InverseProperty("PaymentMethod")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
