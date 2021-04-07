using System;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using DataAccesLayer.Entity;

namespace DataAccesLayer
{
    public class MachineContext : DbContext
    {
        public MachineContext(DbContextOptions<MachineContext> options)
            : base(options)
        {
        }

        #region DbSet's

        public DbSet<Comment> Comments { get; set; }

        public DbSet<House> Houses { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    ID = 1,
                    PostedDate = DateTime.Now,
                    Text = "You are just a degenerate retard",
                    Name = "Allf3",
                    Toxic = true
                });
        }
    }
}
