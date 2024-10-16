using Students.Domain.Entities;
using Students.Domain.Repositories;

namespace Students.DataAccess.Repositories
{
    public class StudentsRepositoryMock : IStudentsRepository
    {
        private int lastId = 0;
        private readonly List<StudentEntity> students = [];

        public Task AddAsync(StudentEntity entity)
        {
            students.Add(entity);
            entity.Id = ++lastId;
            return Task.CompletedTask;
        }

        public Task<IEnumerable<StudentEntity>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<StudentEntity>>(students);
        }

        public Task<StudentEntity?> GetByIdAsync(int id)
        {
            return Task.FromResult(students.Find(_ => _.Id == id));
        }

        public Task<IEnumerable<StudentEntity>> GetByGroupIdAsync(int groupId)
        {
            return Task.FromResult(students.Where(_ => _.GroupId == groupId));
        }

        public Task UpdateAsync(StudentEntity entity)
        {
            StudentEntity? student = students.Find(_ => _.Id == entity.Id);
            if (student != null)
            {
                student.Age = entity.Age;
                student.FirstName = entity.FirstName;
                student.LastName = entity.LastName;
                student.GroupId = entity.GroupId;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(StudentEntity studentEntity)
        {
            students.Remove(studentEntity);
            return Task.CompletedTask;
        }
    }
}