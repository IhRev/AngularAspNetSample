using Students.Domain.Entities;

namespace Students.Domain.Repositories
{
    public interface IGroupsRepository
    {
        Task<IEnumerable<GroupEntity>> GetAllAsync();

        Task AddAsync(GroupEntity entity);

        Task UpdateAsync(GroupEntity entity);
    }
}