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
        [Column("filename")]
        [StringLength(100)]
        public string Filename { get; set; } = null!;
        [Column("uploadDate", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Column("fileType")]
        [StringLength(50)]
        public string FileType { get; set; } = null!;
        [Column("BLOB")]
        public byte[] Blob { get; set; } = null!;
        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Documents")]
        public virtual User User { get; set; } = null!;
    }
}
