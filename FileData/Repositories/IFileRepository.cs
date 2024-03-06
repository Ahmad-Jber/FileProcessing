using FileProcessing.FileData.Entities;
namespace FileProcessing.FileData.Repositories
{
    public interface IFileRepository
    {
        Task InsertFile(CFile file);
        Task InsertFiles(List<CFile> files);
        Task<CFile> GetFile(int id);
        Task<List<CFile>> GetFiles();
    }
}
