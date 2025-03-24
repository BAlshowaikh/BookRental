using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Availability Status")]
    public partial class AvailabilityStatus
    {
        public AvailabilityStatus()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("availabiltyStatusId")]
        public int AvailabiltyStatusId { get; set; }
        [Column("availabilityStatus")]
        [StringLength(50)]
        public string? AvailabilityStatus1 { get; set; }

        [InverseProperty("AvailabilityStatus")]
        public virtual ICollection<Book> Books { get; set; }
    }
}
