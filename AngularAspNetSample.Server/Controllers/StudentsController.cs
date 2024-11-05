using Microsoft.AspNetCore.Mvc;
using Students.Core.DTO;
using Students.Core.Services;

namespace AngularAspNetSample.Server.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentsController(IStudentsService studentsService) : StudentsControllerBase
    {
        private const string GetStudentByIdActionName = "GetStudentById";

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> Get()
        {
            try
            {
                IEnumerable<StudentDTO> students = await studentsService.GetAllAsync();
                if (students.Any())
                {
                    return Ok(students);
                }
                return NoContent();
            }
            catch (Exception e) 
            {
                return HandleException(e);
            }
        }

        [HttpGet("{id}", Name = GetStudentByIdActionName)]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetById([FromRoute] int id)
        {
            try
            {
                StudentDTO? student = await studentsService.GetByIdAsync(id);
                if (student != null)
                {
                    return Ok(student);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpGet]
        [Route("~/groups/{groupId}/students")]
        public async Task<ActionResult<IEnumerable<StudentDTO>>> GetByGroupId([FromRoute] int groupId)
        {
            try
            {
                IEnumerable<StudentDTO> students = await studentsService.GetByGroupIdAsync(groupId);
                if (students.Any())
                {
                    return Ok(students);
                }
                return NoContent();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] StudentCreateDTO student)
        {
            try
            {
                int result = await studentsService.AddAsync(student);
                return CreatedAtRoute(GetStudentByIdActionName, new { id = result }, result);
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] StudentUpdateDTO student)
        {
            try
            {
                await studentsService.UpdateAsync(student);
                return Ok();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await studentsService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }
    }
}