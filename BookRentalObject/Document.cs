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
        [Display(Name = "Document ID")]
        public int DocumentId { get; set; }
        [Column("uploadDate", TypeName = "datetime")]
        [Display(Name = "Upload Date")]
        public DateTime UploadDate { get; set; }
        [Required]
        [Column("BLOB")]
        [Display(Name = "BLOB")]
        public byte[] Blob { get; set; }
        [Column("rentalRequestId")]
        [Display(Name = "Rental Request ID")]
        public int RentalRequestId { get; set; }

        [ForeignKey("RentalRequestId")]
        [InverseProperty("Documents")]
        public virtual RentalRequest RentalRequest { get; set; }
    }
}
