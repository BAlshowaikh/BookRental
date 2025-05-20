using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookRentalObject
{
    public partial class BookRentalDBContext : DbContext
    {
        public BookRentalDBContext()
        {
        }

        public BookRentalDBContext(DbContextOptions<BookRentalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AvailabilityStatus> AvailabilityStatuses { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookCondition> BookConditions { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<ExtraCharge> ExtraCharges { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public virtual DbSet<RentalRequest> RentalRequests { get; set; }
        public virtual DbSet<RentalRequestStatus> RentalRequestStatuses { get; set; }
        public virtual DbSet<RentalTransaction> RentalTransactions { get; set; }
        public virtual DbSet<ReturnRecord> ReturnRecords { get; set; }
        public virtual DbSet<Suggestion> Suggestions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Log> Log { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=reboot08.com,1450;Database=BookRental;User Id=sa;Password='caliber,willpower,enjoyably,ending,giggling,P5';Encrypt=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK_AUDIT_TRAILS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditTrails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AUDIT_TRAILS_User");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Author");

                entity.HasOne(d => d.AvailabilityStatus)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AvailabilityStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Availability Status");

                entity.HasOne(d => d.BookCondition)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.BookConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Equipment Condition");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Category");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_Book_Image");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasOne(d => d.RentalRequest)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.RentalRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_RentalRequest2");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Book");

                entity.HasOne(d => d.ReturnRecord)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ReturnRecordId)
                    .HasConstraintName("FK_Feedback_ReturnRecords");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_User");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<RentalRequest>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Request_Equipment");

                entity.HasOne(d => d.RentalRequestStatus)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.RentalRequestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Request_Rental Request Status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Request_User");
            });

            modelBuilder.Entity<RentalTransaction>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Transaction_Book");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Transaction_Payment Method");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Transaction_Payment Status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental Transaction_User");
            });

            modelBuilder.Entity<ReturnRecord>(entity =>
            {
                entity.HasOne(d => d.BookCondition)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.BookConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return Records_Equipment Condition");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return Records_Equipment");

                entity.HasOne(d => d.ExtraCharges)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.ExtraChargesId)
                    .HasConstraintName("FK_Return Records_Extra Charges");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return Records_Rental Transaction");
            });

            modelBuilder.Entity<Suggestion>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Suggestions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suggestion_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_User Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
