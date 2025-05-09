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
        [Column("uploadDate", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Required]
        [Column("BLOB")]
        public byte[] Blob { get; set; }
        [Column("rentalRequestId")]
        public int RentalRequestId { get; set; }

        [ForeignKey("RentalRequestId")]
        [InverseProperty("Documents")]
        public virtual RentalRequest RentalRequest { get; set; }
    }
}
