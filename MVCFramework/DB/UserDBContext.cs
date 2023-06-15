using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCFramework.DB.Entities;

namespace MVCFramework.DB
{
    public class UserDBContext :IdentityDbContext<User>
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }
        //public DbSet<Attrazione> Attrazioni { get; set; }
        //questo per creare altri tabella dentro il DB ,nome della tabella è Attrazioni 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
