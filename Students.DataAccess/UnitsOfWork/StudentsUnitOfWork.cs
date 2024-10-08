using Students.Domain.Repositories;
using Students.Domain.UnitsOfWork;

namespace Students.DataAccess.UnitsOfWork
{
    public class StudentsUnitOfWork : IStudentsUnitOfWork
    {
        public IStudentsRepository StudentsRepository { get; }

        public IGroupsRepository GroupsRepository { get; }

        public StudentsUnitOfWork(IStudentsRepository studentsRepository, IGroupsRepository groupsRepository)
        {
            StudentsRepository = studentsRepository;
            GroupsRepository = groupsRepository;
        }

        public void Commit() { }
    }
}