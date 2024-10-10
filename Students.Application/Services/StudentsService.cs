using AutoMapper;
using Students.Core.DTO;
using Students.Core.Services;
using Students.Domain.Entities;
using Students.Domain.UnitsOfWork;

namespace Students.Application.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly IStudentsUnitOfWork studentsUnitOfWork;
        private readonly IMapper mapper;

        public StudentsService(IStudentsUnitOfWork studentsUnitOfWork, IMapper mapper)
        {
            this.studentsUnitOfWork = studentsUnitOfWork;
            this.mapper = mapper;
        }

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

        public async Task AddAsync(StudentCreateDTO student)
        {
            
        }
    }
}