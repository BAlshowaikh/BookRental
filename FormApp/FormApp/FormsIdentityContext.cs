using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ProjectFormApp
{ 

public class FormsIdentityContext : IdentityDbContext<IdentityUser>
{
        public FormsIdentityContext()
        {

        }
        public FormsIdentityContext(DbContextOptions<FormsIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=reboot08.com,1450;Database=BookRentalIdentity;User Id=sa;Password='caliber,willpower,enjoyably,ending,giggling,P5';Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookRentalIdentity;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    DbSet<IdentityUser> ApplicationUsers { get; set; }
}
}