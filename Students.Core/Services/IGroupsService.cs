using Students.Core.DTO;

namespace Students.Core.Services
{
    public interface IGroupsService
    {
        Task<IEnumerable<GroupDTO>> GetAllAsync();

        Task AddAsync(GroupDTO group);

        Task UpdateAsync(GroupDTO group);

        Task DeleteAsync(int id);
    }
}