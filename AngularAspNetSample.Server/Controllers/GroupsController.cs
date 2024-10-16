using Microsoft.AspNetCore.Mvc;
using Students.Core.DTO;
using Students.Core.Services;

namespace AngularAspNetSample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController(IGroupsService groupsService) : StudentsControllerBase
    {
        private const string GetAllGroupsActionName = "GetAllGroups";

        [HttpGet(Name = GetAllGroupsActionName)]
        public async Task<ActionResult<IEnumerable<GroupDTO>>> Get()
        {
            try
            {
                IEnumerable<GroupDTO> groups = await groupsService.GetAllAsync();
                if (groups.Any())
                {
                    return Ok(groups);
                }
                return NoContent();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] GroupDTO group)
        {
            try
            {
                int result = await groupsService.AddAsync(group);
                return CreatedAtRoute(GetAllGroupsActionName, new { id = result }, result);
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] GroupDTO group)
        {
            try
            {
                await groupsService.UpdateAsync(group);
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
                await groupsService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return HandleException(e);
            }
        }
    }
}