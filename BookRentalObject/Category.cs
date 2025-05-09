using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("categoryId")]
        public int CategoryId { get; set; }
        [Required]
        [Column("categoryName")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Column("isActive")]
        public bool IsActive { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
