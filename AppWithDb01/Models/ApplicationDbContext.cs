using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AppWithDb01.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Entry> Entries { get; set; }
        public DbSet<TimeOfMeasurement> TimeOfMeasurements { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}