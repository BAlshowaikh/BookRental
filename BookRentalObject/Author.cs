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
        public int AuthorId { get; set; }
        [Column("firstName")]
        [StringLength(100)]
        public string FirstName { get; set; } = null!;
        [Column("lastName")]
        [StringLength(100)]
        public string LastName { get; set; } = null!;
        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Book> Books { get; set; }

        public String FullName { get { return FirstName + " " + LastName; } }
    }
}
