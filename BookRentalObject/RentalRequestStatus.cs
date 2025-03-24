using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Rental Request Status")]
    public partial class RentalRequestStatus
    {
        public RentalRequestStatus()
        {
            RentalRequests = new HashSet<RentalRequest>();
        }

        [Key]
        [Column("rentalRequestStatusId")]
        public int RentalRequestStatusId { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string? Status { get; set; }

        [InverseProperty("RentalRequestStatus")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}
