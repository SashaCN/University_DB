using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_DB.Data.Models;

namespace University_DB.Data
{

    public class UniversityContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                // Entity
            // Primary key 
            modelBuilder.Entity<Entity>().HasKey(e => e.Id);

            modelBuilder.Entity<Entity>()
                .Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Entity>()
                .Property(e => e.DeletedAt)
                .HasDefaultValueSql("NULL");

                // Specailzation
            modelBuilder.Entity<Specialization>()
                .HasMany(sp => sp.Subjects)
                .WithMany(s => s.Specializations)
                .UsingEntity(j => j.ToTable("SpecailizationSubject"));

                // Journal
            modelBuilder.Entity<Journal>()
                .HasOne(s => s.Student)
                .WithOne(j => j.Journal)
                .HasForeignKey<Student>(s => s.JournalId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectingString = IConfigurationManager.AppSettings["ConnectionStriong"];
            var serverVersion = new MySqlServerVersion(new Version(5, 7, 39));
            optionsBuilder.UseMySql(serverVersion);
        }
    }
}
