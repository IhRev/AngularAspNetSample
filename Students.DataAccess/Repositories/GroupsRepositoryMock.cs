﻿using Students.Domain.Entities;
using Students.Domain.Repositories;

namespace Students.DataAccess.Repositories
{
    public class GroupsRepositoryMock : IGroupsRepository
    {
        private int lastId = 0;
        private readonly List<GroupEntity> groups = new List<GroupEntity>() { new GroupEntity() { Id = 1, Name = "IT-681" }, new GroupEntity() { Id = 2, Name = "IT-682" } };

        public Task AddAsync(GroupEntity entity)
        {
            groups.Add(entity);
            entity.Id = ++lastId;
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