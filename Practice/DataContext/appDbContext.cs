using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.DataContext
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options) : base(options)
        {
        }
        public DbSet<Emp> Emp{ get; set; }
        public DbSet<Dept> Dept { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            List<Dept> list = new List<Dept>() 
            { 
                new Dept{ Id = 1, Deptname="IT"},
                new Dept{ Id = 2, Deptname="Engineering"},
                new Dept{ Id = 3, Deptname="HR"},
                new Dept{ Id = 4, Deptname="Finance"},
                new Dept{ Id = 5, Deptname="Talent Equisition"},
            };

            modelBuilder.Entity<Dept>().HasData(list);

        }

    }
}
