using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Rental Request")]
    public partial class RentalRequest
    {
        [Key]
        [Column("requestId")]
        public int RequestId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("rentalRequestStatusId")]
        public int RentalRequestStatusId { get; set; }
        [Column("bookId")]
        public int BookId { get; set; }
        [Column("rentalStartDate", TypeName = "datetime")]
        public DateTime RentalStartDate { get; set; }
        [Column("totalCost")]
        public double TotalCost { get; set; }
        [Column("returnDate", TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }

        [ForeignKey("BookId")]
        [InverseProperty("RentalRequests")]
        public virtual Book Book { get; set; }
        [ForeignKey("RentalRequestStatusId")]
        [InverseProperty("RentalRequests")]
        public virtual RentalRequestStatus RentalRequestStatus { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("RentalRequests")]
        public virtual User User { get; set; }
    }
}
