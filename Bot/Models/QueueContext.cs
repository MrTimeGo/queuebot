using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramBot.Models
{
    public class QueueContext : DbContext
    {
        public DbSet<User> Users {  get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public QueueContext(DbContextOptions<QueueContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User

            modelBuilder.Entity<User>()
                .HasOne(u => u.Group)
                .WithMany(g => g.Users)
                .HasForeignKey(u => u.GroupId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Records)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            // Group
            
            modelBuilder.Entity<Group>()
                .HasMany(g => g.Users)
                .WithOne(u => u.Group)
                .HasForeignKey(u => u.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Subjects)
                .WithOne(s => s.Group)
                .HasForeignKey(s => s.GroupId)
                .OnDelete(DeleteBehavior.Cascade);


            // Record

            modelBuilder.Entity<Record>()
                .HasOne(u => u.User)
                .WithMany(u => u.Records)
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Record>()
                .HasOne(r => r.Group)
                .WithMany()
                .HasForeignKey(r => r.GroupId);

            modelBuilder.Entity<Record>()
                .HasOne(r => r.Subject)
                .WithMany(s => s.Records)
                .HasForeignKey(r => r.SubjectId);


            // Subject

            modelBuilder.Entity<Subject>()
                .HasOne(s => s.Group)
                .WithMany(g => g.Subjects)
                .HasForeignKey(s => s.GroupId);

            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Records)
                .WithOne(r => r.Subject)
                .HasForeignKey(r => r.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
