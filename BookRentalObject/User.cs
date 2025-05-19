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
            Logs = new HashSet<Log>();
            Notifications = new HashSet<Notification>();
            RentalRequests = new HashSet<RentalRequest>();
            RentalTransactions = new HashSet<RentalTransaction>();
            Suggestions = new HashSet<Suggestion>();
        }

        [Key]
        [Column("userId")]
        [Display(Name = "User ID")]
        public int UserId { get; set; }
        [Required]
        [Column("firstName")]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Column("lastName")]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [Column("email")]
        [StringLength(100)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Column("userRoleId")]
        [Display(Name = "User Role")]
        public int UserRoleId { get; set; }
        [Column("contactNo")]
        [StringLength(10)]
        [Display(Name = "Contact number")]
        public string ContactNo { get; set; }
        [Column("isActive")]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        public String FullName { get { return FirstName + " " + LastName;}}

        [ForeignKey("UserRoleId")]
        [InverseProperty("Users")]
        public virtual UserRole UserRole { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AuditTrail> AuditTrails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Log> Logs { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Suggestion> Suggestions { get; set; }
    }
}
