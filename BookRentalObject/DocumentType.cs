using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Document Type")]
    public partial class DocumentType
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        [Column("documetTypeId")]
        public int DocumetTypeId { get; set; }
        [Column("documentType")]
        [StringLength(100)]
        public string? DocumentType1 { get; set; }

        [InverseProperty("DocumentType")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
