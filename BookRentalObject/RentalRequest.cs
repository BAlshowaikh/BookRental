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
        [Display(Name = "Rental Request ID")]
        public int RequestId { get; set; }
        [Column("userId")]
        [Display(Name = "Username")]
        public int UserId { get; set; }
        [Column("rentalRequestStatusId")]
        [Display(Name = "Rental Request Status")]
        public int RentalRequestStatusId { get; set; }
        [Column("bookId")]
        [Display(Name = "Book Name")]
        public int BookId { get; set; }
        [Column("rentalStartDate", TypeName = "datetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Rental Start Date")]
        public DateTime RentalStartDate { get; set; }
        [Column("totalCost")]
        [Display(Name = "Total Rent Cost")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total cost must be greater than 0.")]
        public double TotalCost { get; set; }
        [Column("returnDate", TypeName = "datetime")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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
    }
}
