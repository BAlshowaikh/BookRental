using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            AuditTrails = new HashSet<AuditTrail>();
            Documents = new HashSet<Document>();
            Logs = new HashSet<Log>();
            Notifications = new HashSet<Notification>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        public string FullName { get => this.FirstName + " " + this.LastName; }

        [Key]
        [Column("userId")]
        public int UserId { get; set; }
        [Column("firstName")]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Column("lastName")]
        [StringLength(50)]
        public string? LastName { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Column("userRoleId")]
        public int UserRoleId { get; set; }

        [ForeignKey("UserRoleId")]
        [InverseProperty("Users")]
        public virtual UserRole UserRole { get; set; } = null!;
        [InverseProperty("User")]
        public virtual ICollection<AuditTrail> AuditTrails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Log> Logs { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}
