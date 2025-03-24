using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column("notificationId")]
        public int NotificationId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Column("type")]
        [StringLength(50)]
        public string? Type { get; set; }
        [Column("message")]
        [StringLength(100)]
        public string? Message { get; set; }
        [Column("status")]
        [StringLength(50)]
        public string? Status { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Notifications")]
        public virtual User User { get; set; } = null!;
    }
}
