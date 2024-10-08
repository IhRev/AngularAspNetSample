using Students.Domain.Entities;
using Students.Domain.Repositories;

namespace Students.DataAccess.Repositories
{
    public class GroupsRepositoryMock : IGroupsRepository
    {
        private readonly List<GroupEntity> groups = new List<GroupEntity>();

        public Task AddAsync(GroupEntity entity)
        {
            groups.Add(entity);
            return Task.CompletedTask;
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
    }
} 