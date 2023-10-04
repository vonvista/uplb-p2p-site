using Microsoft.EntityFrameworkCore;
using UPLB_P2P.Website.Models.Domain;

namespace P2P.Data
{
    public class P2PDbContext : DbContext
    {
        public P2PDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
