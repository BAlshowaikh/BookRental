using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Author")]
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("authorId")]
        [Display(Name = "Author ID")]
        public int AuthorId { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Column("lastName")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Full Name")]
        public String FullName { get { return FirstName + " " + LastName; } }

        [InverseProperty("Author")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
