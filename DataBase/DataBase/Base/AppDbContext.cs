using DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Base
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\UrlShorter\\Db.mdf;Integrated Security=True;Connect Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<UrlTable>()
                .HasOne(u => u.User)
                .WithMany()
                .HasForeignKey(u => u.UserId);
        }

        public DbSet<UrlTable> UrlsTable { get; set; }
        public DbSet<UserTable> UsersTable { get; set; }
    }
}
