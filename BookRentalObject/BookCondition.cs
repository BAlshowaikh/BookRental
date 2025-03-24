using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Book Condition")]
    public partial class BookCondition
    {
        public BookCondition()
        {
            Books = new HashSet<Book>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("bookConditionId")]
        public int BookConditionId { get; set; }
        [Column("returnCondition")]
        [StringLength(100)]
        public string? ReturnCondition { get; set; }

        [InverseProperty("BookCondition")]
        public virtual ICollection<Book> Books { get; set; }
        [InverseProperty("BookCondition")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}
