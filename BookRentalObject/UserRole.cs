using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookRentalObject
{
    [Table("User Role")]
    public partial class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [Column("userRoleId")]
        public int UserRoleId { get; set; }
        [Required]
        [Column("role")]
        [StringLength(50)]
        public string Role { get; set; }

        [InverseProperty("UserRole")]
        public virtual ICollection<User> Users { get; set; }
    }
}
