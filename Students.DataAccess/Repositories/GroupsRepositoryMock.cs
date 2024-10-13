using Students.Domain.Entities;
using Students.Domain.Repositories;

namespace Students.DataAccess.Repositories
{
    public class GroupsRepositoryMock : IGroupsRepository
    {
        private int lastId = 0;
        private readonly List<GroupEntity> groups = new List<GroupEntity>();

        public Task<int> AddAsync(GroupEntity entity)
        {
            groups.Add(entity);
            return Task.FromResult(++lastId);
        }

        public Task<IEnumerable<GroupEntity>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<GroupEntity>>(groups);
        }

        public Task UpdateAsync(GroupEntity entity)
        {
            GroupEntity? group = groups.Find(_ => _.Id == entity.Id);
            if (group != null)
            {
                group.Name = entity.Name;
            }
            return Task.CompletedTask;
        }

        public Task<GroupEntity?> GetByIdAsync(int id)
        {
            return Task.FromResult(groups.Find(_ => _.Id == id));
        }

        public Task DeleteAsync(GroupEntity group)
        {
            groups.Remove(group);
            return Task.CompletedTask;
        }
    }
} 