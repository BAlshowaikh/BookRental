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
        public RentalRequest()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        [Column("requestId")]
        [Display(Name = "Request ID")]
        public int RequestId { get; set; }
        [Column("userId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Column("rentalRequestStatusId")]
        [Display(Name = "Status ID")]
        public int RentalRequestStatusId { get; set; }
        [Column("bookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        [Column("rentalStartDate", TypeName = "datetime")]
        [Display(Name = "Start Date")]
        public DateTime RentalStartDate { get; set; }
        [Column("totalCost")]
        [Display(Name = "Total Cost")]
        public double TotalCost { get; set; }
        [Column("returnDate", TypeName = "datetime")]
        [Display(Name = "Return Date")]
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
        [InverseProperty("RentalRequest")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
