using Students.Domain.Repositories;

namespace Students.Domain.UnitsOfWork
{
    public interface IStudentsUnitOfWork
    {
        IStudentsRepository StudentsRepository { get; }

        IGroupsRepository GroupsRepository { get; }

        void Commit();
    }
}