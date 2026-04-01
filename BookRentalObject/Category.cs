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
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
        [Required]
        [Column("categoryName")]
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Column("isActive")]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

        [InverseProperty("Category")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
