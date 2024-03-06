using FileProcessing.FileData.Dtos;
using FileProcessing.FileData.Repositories;

namespace FileProcessing.FileData.Services
{
    public class FileService: IFileService
    {
        private readonly IFileRepository _fileRepository;
        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public async Task InsertFile(InsertFileDto file)
        {
            await _fileRepository.InsertFile(file);
        }
        public async Task InsertFiles(List<InsertFileDto> files)
        {
            await _fileRepository.InsertFiles(files);
        }
        public async Task<GetFileDto> GetFile(int id)
        {
            return await _fileRepository.GetFile(id);
        }
        public async Task<List<GetFileDto>> GetFiles()
        {
            return await _fileRepository.GetFiles();
        }
    }
}
