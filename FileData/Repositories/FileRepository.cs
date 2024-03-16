using FileProcessing.DBContexts;
using FileProcessing.FileData.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileProcessing.FileData.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly DBContext _dBContext;
        public FileRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<CFile> GetFile(int id)
        {
            return await _dBContext.Files.SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<CFile>> GetAllFiles()
        {
            return await _dBContext.Files.ToListAsync();
        }

        public async Task InsertFile(CFile file)
        {
            await _dBContext.Files.AddAsync(file);
        }
    }
}
