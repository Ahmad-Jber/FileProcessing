using Microsoft.EntityFrameworkCore;
using FileProcessing.FileData.Entities;

namespace FileProcessing.DBContexts
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) {}
        public DbSet<CFile>? Files { get; set; }
    }
}
