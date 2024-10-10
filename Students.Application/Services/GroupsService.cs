using OneOf;
using OneOf.Types;
using Students.Core.DTO;
using Students.Core.Services;
using Students.Domain.UnitsOfWork;

namespace Students.Application.Services
{
    public class GroupsService : IGroupsService
    {
        private readonly IStudentsUnitOfWork studentsUnitOfWork;

        public GroupsService(IStudentsUnitOfWork studentsUnitOfWork)
        {
            this.studentsUnitOfWork = studentsUnitOfWork;
        }

        public Task<OneOf<Success>> AddAsync(GroupDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GroupDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OneOf<Success>> UpdateAsync(GroupDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
