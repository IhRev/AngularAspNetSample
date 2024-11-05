using AutoMapper;
using Students.Core.DTO;
using Students.Domain.Entities;

namespace Students.Application.Mappings
{
    public class GroupsProfile : Profile
    {
        public GroupsProfile()
        {
            CreateMap<GroupDTO, GroupEntity>().ReverseMap();
        }
    }
}