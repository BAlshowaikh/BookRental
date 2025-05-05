using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Suggestion")]
    public partial class Suggestion
    {
        [Key]
        [Column("suggestionId")]
        public int SuggestionId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Required]
        [Column("subject")]
        [StringLength(100)]
        public string Subject { get; set; }
        [Required]
        [Column("message")]
        public string Message { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Suggestions")]
        public virtual User User { get; set; }
    }
}
