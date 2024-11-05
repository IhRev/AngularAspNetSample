using AutoMapper;
using Students.Core.DTO;
using Students.Domain.Entities;

namespace Students.Application.Mappings
{
    public class StudentProfile : Profile
    {
        public StudentProfile() 
        {
            CreateMap<StudentEntity, StudentDTO>();
            CreateMap<StudentCreateDTO, StudentEntity>();
            CreateMap<StudentUpdateDTO, StudentEntity>();
        }
    }
}