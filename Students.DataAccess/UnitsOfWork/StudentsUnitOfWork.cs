using Students.Domain.Repositories;
using Students.Domain.UnitsOfWork;

namespace Students.DataAccess.UnitsOfWork
{
    public class StudentsUnitOfWork(IStudentsRepository studentsRepository, IGroupsRepository groupsRepository) : IStudentsUnitOfWork
    {
        public IStudentsRepository StudentsRepository { get; } = studentsRepository;

        public IGroupsRepository GroupsRepository { get; } = groupsRepository;

        public Task CommitAsync() { return Task.CompletedTask; }
    }
}