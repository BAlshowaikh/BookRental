using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Document")]
    public partial class Document
    {
        [Key]
        [Column("documentId")]
        public int DocumentId { get; set; }
        [Required]
        [Column("filename")]
        [StringLength(100)]
        public string Filename { get; set; }
        [Column("uploadDate", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Required]
        [Column("fileType")]
        [StringLength(50)]
        public string FileType { get; set; }
        [Required]
        [Column("BLOB")]
        public byte[] Blob { get; set; }
        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Documents")]
        public virtual User User { get; set; }
    }
}
