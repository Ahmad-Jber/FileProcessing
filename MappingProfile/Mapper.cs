using AutoMapper;
using FileProcessing.FileData.Dtos;
using FileProcessing.FileData.Entities;
namespace FileProcessing.MappingProfile
{
    public class Mapper :Profile
    {
        public Mapper()
        {
            CreateMap<InsertFileDto, CFile>();
            CreateMap<CFile, GetAllFilesDto>();
            CreateMap<CFile, GetFileDto>();
        }
    }
}
