using AutoMapper;
using Students.Core.DTO;
using Students.Core.Services;
using Students.Domain.Entities;
using Students.Domain.UnitsOfWork;

namespace Students.Application.Services
{
    public class GroupsService(IStudentsUnitOfWork studentsUnitOfWork, IMapper mapper) : IGroupsService
    {
        public async Task<int> AddAsync(GroupDTO group)
        {
            GroupEntity groupEntity = mapper.Map<GroupEntity>(group);
            await studentsUnitOfWork.GroupsRepository.AddAsync(groupEntity);
            await studentsUnitOfWork.CommitAsync();
            return groupEntity.Id;
        }

        public async Task<IEnumerable<GroupDTO>> GetAllAsync()
        {
            IEnumerable<GroupEntity> groups = await studentsUnitOfWork.GroupsRepository.GetAllAsync();
            return mapper.Map<IEnumerable<GroupDTO>>(groups);
        }

        public async Task UpdateAsync(GroupDTO group)
        {
            GroupEntity? groupEntity = await studentsUnitOfWork.GroupsRepository.GetByIdAsync(group.Id);
            if (groupEntity == null)
            {
                return;
            }
            mapper.Map(group, groupEntity);
            await studentsUnitOfWork.GroupsRepository.UpdateAsync(groupEntity);
            await studentsUnitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            GroupEntity? groupEntity = await studentsUnitOfWork.GroupsRepository.GetByIdAsync(id);
            if (groupEntity == null)
            {
                return;
            }
            await studentsUnitOfWork.GroupsRepository.DeleteAsync(groupEntity);
            await studentsUnitOfWork.CommitAsync();
        }
    }
}