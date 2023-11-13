using ASAPAirsoft.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASAPAirsoft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AirsoftGearModel> AirsoftGearModel { get; set; } = null!;
        public virtual DbSet<AirsoftGunModel> AirsoftGunModel { get; set; } = null!;
        public virtual DbSet<AirsoftLocationModel> AirsoftLocationModel { get; set; } = null!;

    }
}