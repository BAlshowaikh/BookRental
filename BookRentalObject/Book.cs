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
            RentalRequests = new HashSet<RentalRequest>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("bookId")]
        public int BookId { get; set; }
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Column("description")]
        [StringLength(100)]
        public string? Description { get; set; }
        [Column("categoryId")]
        public int CategoryId { get; set; }
        [Column("rentalPrice")]
        public double RentalPrice { get; set; }
        [Column("bookConditionId")]
        public int BookConditionId { get; set; }
        [Column("availabilityStatusId")]
        public int AvailabilityStatusId { get; set; }
        [Column("authorId")]
        public int AuthorId { get; set; }
        [Column("publishDate", TypeName = "datetime")]
        public DateTime? PublishDate { get; set; }
        [Column("ISBN")]
        [StringLength(50)]
        public string Isbn { get; set; } = null!;

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
        [InverseProperty("Book")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("Book")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }

    }
}
