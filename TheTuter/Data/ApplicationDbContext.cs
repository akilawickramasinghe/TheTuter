using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheTuter.Models;

namespace TheTuter.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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
        }

        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UploadLecture> Lectures { get; set; }
        public DbSet<UploadQuizes> Quizes { get; set; }
        public DbSet<PaymentInformation> StudentPaymentInfos { get; set; }
    }

}
