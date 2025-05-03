using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Book")]
    public partial class Book
    {
        public Book()
        {
            Feedbacks = new HashSet<Feedback>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("bookId")]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }
        [Column("name")]
        [StringLength(100)]
        [Display(Name = "Book Name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Column("categoryId")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [Column("rentalPrice")]
        [Display(Name = "Rental Price (in BHD)")]
        public double RentalPrice { get; set; }
        [Column("bookConditionId")]
        [Display(Name = "Book Condition")]
        public int BookConditionId { get; set; }
        [Column("availabilityStatusId")]
        [Display(Name = "Availability Status")]
        public int AvailabilityStatusId { get; set; }
        [Column("authorId")]
        [Display(Name = "Author Fullname")]
        public int AuthorId { get; set; }
        [Column("publishDate", TypeName = "datetime")]
        [Display(Name = "Publish Date")]
        public DateTime? PublishDate { get; set; }
        [Column("ISBN")]
        [StringLength(50)]
        [Display(Name = "ISBN")]
        public string Isbn { get; set; } = null!;
        [Column("isActive")]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        [Column("imageID")]
        [Display(Name = "Book Image")]
        public int? ImageId { get; set; }

        [ForeignKey("AuthorId")]
        [InverseProperty("Books")]
        public virtual Author Author { get; set; } = null!;
        [ForeignKey("AvailabilityStatusId")]
        [InverseProperty("Books")]
        public virtual AvailabilityStatus AvailabilityStatus { get; set; } = null!;
        [ForeignKey("BookConditionId")]
        [InverseProperty("Books")]
        public virtual BookCondition BookCondition { get; set; } = null!;
        [ForeignKey("CategoryId")]
        [InverseProperty("Books")]
        public virtual Category Category { get; set; } = null!;
        [ForeignKey("ImageId")]
        [InverseProperty("Books")]
        public virtual Image? Image { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
