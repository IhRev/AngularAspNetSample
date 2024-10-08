using Students.Domain.Entities;

namespace Students.Domain.Repositories
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<StudentEntity>> GetAllAsync();

        Task<IEnumerable<StudentEntity>> GetByGroupIdAsync(int groupId);

        Task<StudentEntity?> GetByIdAsync(int id);

        Task AddAsync(StudentEntity entity); 

        Task UpdateAsync(StudentEntity entity); 
    }
}