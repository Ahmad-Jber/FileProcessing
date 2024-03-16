using AutoMapper;
using FileProcessing.FileData.Dtos;
using FileProcessing.FileData.Entities;
using FileProcessing.FileData.Repositories;

namespace FileProcessing.FileData.Services
{
    public class FileService: IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly IMapper _mapper;
        public FileService(IFileRepository fileRepository, IMapper mapper)
        {
            _fileRepository = fileRepository;
            _mapper = mapper;
        }
        public async Task InsertFile(InsertFileDto file)
        {   
            await _fileRepository.InsertFile(_mapper.Map<InsertFileDto,CFile>(file));
        }
        public async Task<GetFileDto> GetFile(int id)
        {
            return _mapper.Map<CFile,GetFileDto>(await _fileRepository.GetFile(id));
        }

        public async Task<List<GetAllFilesDto>> GetAllFiles()
        {
            return _mapper.Map<List<CFile>, List<GetAllFilesDto>>(await _fileRepository.GetAllFiles());
        }
    }
}
