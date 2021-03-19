using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTuter.Models;

namespace TheTuter.Data
{
    public class ApplicationDbContext : DbContext 
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        { 
        } 
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            base.OnModelCreating(modelBuilder); 
            modelBuilder.ApplyConfiguration(new RoleConfiguration()); 
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });

            modelBuilder.Entity<CourseStudent>()
                .HasKey(Cs => new {Cs.CourseId,Cs.StudentId });

            modelBuilder.Entity<CourseStudent>()
                .HasOne(Cs => Cs.Course)
                .WithMany(Cs=>Cs.Students)
                .HasForeignKey(Cs => Cs.CourseId);
            modelBuilder.Entity<CourseStudent>()
                .HasOne(Cs => Cs.Student)
                .WithMany(Cs => Cs.Course)
                .HasForeignKey(Cs => Cs.StudentId);
          

        } 
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
    }
  
}
