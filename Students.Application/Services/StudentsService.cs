using AutoMapper;
using Students.Core.DTO;
using Students.Core.Services;
using Students.Domain.Entities;
using Students.Domain.UnitsOfWork;

namespace Students.Application.Services
{
    public class StudentsService(IStudentsUnitOfWork studentsUnitOfWork, IMapper mapper) : IStudentsService
    {
        public async Task<IEnumerable<StudentDTO>> GetAllAsync()
        {
            IEnumerable<StudentEntity> students = await studentsUnitOfWork.StudentsRepository.GetAllAsync();
            return mapper.Map<IEnumerable<StudentDTO>>(students);
        }

        public async Task<StudentDTO?> GetByIdAsync(int id)
        {
            StudentEntity? student = await studentsUnitOfWork.StudentsRepository.GetByIdAsync(id);
            return mapper.Map<StudentDTO>(student);
        }

        public async Task<IEnumerable<StudentDTO>> GetByGroupIdAsync(int groupId)
        {
            IEnumerable<StudentEntity> students = await studentsUnitOfWork.StudentsRepository.GetByGroupIdAsync(groupId);
            return mapper.Map<IEnumerable<StudentDTO>>(students);
        }

        public async Task<int> AddAsync(StudentCreateDTO student)
        {
            StudentEntity studentEntity = mapper.Map<StudentEntity>(student);
            await studentsUnitOfWork.StudentsRepository.AddAsync(studentEntity);
            await studentsUnitOfWork.CommitAsync();
            return studentEntity.Id;
        }

        public async Task UpdateAsync(StudentUpdateDTO student)
        {
            StudentEntity? studentEntity = await studentsUnitOfWork.StudentsRepository.GetByIdAsync(student.Id);
            if (studentEntity == null)
            {
                return;
            }
            mapper.Map(student, studentEntity);
            await studentsUnitOfWork.StudentsRepository.UpdateAsync(studentEntity);
            await studentsUnitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(int id)
        {
            StudentEntity? studentEntity = await studentsUnitOfWork.StudentsRepository.GetByIdAsync(id);
            if (studentEntity == null)
            {
                return;
            }
            await studentsUnitOfWork.StudentsRepository.DeleteAsync(studentEntity);
            await studentsUnitOfWork.CommitAsync();
        }
    }
}