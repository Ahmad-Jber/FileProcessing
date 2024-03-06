using FileProcessing.FileData.Dtos;
using FileProcessing.FileData.Entities;

namespace FileProcessing.FileData.Services
{
    public interface IFileService
    {
        Task InsertFile(InsertFileDto file);
        Task InsertFiles(List<InsertFileDto> files);
        Task<GetFileDto> GetFile(int id);
        Task<List<GetFileDto>> GetFiles();
    }
}
