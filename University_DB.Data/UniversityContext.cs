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
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Journal> Journals { get; set; }

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

                // Student
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Journal)
                .WithOne(j => j.Student)
                .HasForeignKey<Student>(s => s.JournalId);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Specialization)
                .WithMany(sp => sp.Student)
                .HasForeignKey(s => s.SpecializationlId);

                // Teacher
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Specializations)
                .WithMany(sp => sp.Teachers)
                .UsingEntity(j => j.ToTable("TeacherSpecialization"));

                // Exam
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Subject)
                .WithOne(s => s.Exam)
                .HasForeignKey<Exam>(e => e.Subject_id);

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.Journal)
                .WithMany(j => j.Exams)
                .HasForeignKey(e => e.Journal_id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectingString = IConfigurationManager.AppSettings["ConnectionString"];
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));
            optionsBuilder.UseMySql("server=127.0.0.1:3306;user=root;password=root;database=university", serverVersion);
        }
    }
}
