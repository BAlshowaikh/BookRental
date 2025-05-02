using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Image")]
    public partial class Image
    {
        public Image()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("imageID")]
        public int ImageId { get; set; }
        [Column("imageName")]
        [StringLength(50)]
        public string ImageName { get; set; } = null!;
        [Column("BLOB")]
        public byte[] Blob { get; set; } = null!;
        [Column("imageType")]
        [StringLength(50)]
        public string ImageType { get; set; } = null!;

        [InverseProperty("Image")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
