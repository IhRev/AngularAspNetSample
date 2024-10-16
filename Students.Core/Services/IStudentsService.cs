using Students.Core.DTO;

namespace Students.Core.Services
{
    public interface IStudentsService
    {
        Task<int> AddAsync(StudentCreateDTO student);

        Task<IEnumerable<StudentDTO>> GetAllAsync();

        Task<IEnumerable<StudentDTO>> GetByGroupIdAsync(int groupId);

        Task<StudentDTO?> GetByIdAsync(int id);

        Task UpdateAsync(StudentUpdateDTO student);

        Task DeleteAsync(int id);
    }
}