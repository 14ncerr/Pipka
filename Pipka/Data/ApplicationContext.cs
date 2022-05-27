using Microsoft.EntityFrameworkCore;
using Pipka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pipka.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAndDiscipline> TeacherAndDisciplines  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>()
            .HasOne<ClassTime>(s => s.ClassTime)
            .WithMany(c => c.Schedules)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Schedule>()
            .HasOne<TeacherAndDiscipline>(s => s.TeacherAndDiscipline)
            .WithMany(d => d.Schedules)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Schedule>()
           .HasOne<Group>(s => s.Group)
           .WithMany(g => g.Schedules)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TeacherAndDiscipline>()
                .HasOne<Teacher>(t => t.Teacher)
                .WithMany(td => td.TeacherAndDisciplines)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TeacherAndDiscipline>()
               .HasOne<Discipline>(t => t.Discipline)
               .WithMany(td => td.TeacherAndDisciplines)
               .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=PC-232-13\SQLEXPRESS;Database=PKursovaDB;User Id=U-19; Password=19$RPEe;";
            //string connectionString = @"Server=DESKTOP-IL38R2G\SQLEXPRESS;Database=PKursovaDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
