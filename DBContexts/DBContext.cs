using Microsoft.EntityFrameworkCore;
using FileProcessing.FileData.Entities;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FileProcessing.DBContexts
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<CFile> Files { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CFile>()
                .HasKey(p=>p.Id);
            modelBuilder.Entity<CFile>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
