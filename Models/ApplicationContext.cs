using Microsoft.EntityFrameworkCore;

namespace Relationships_in_efcore.Models
{
    public class ApplicationContext : DbContext
    {


        public ApplicationContext(DbContextOptions<ApplicationContext> opt) : base(opt){

        }

        public DbSet<Comment> Comments{set;get;}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
        }
    }
}