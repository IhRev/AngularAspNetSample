using Microsoft.AspNetCore.Mvc;
using Students.Core.Services;

namespace AngularAspNetSample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupsService groupsService;

        public GroupsController(IGroupsService groupsService)
        {
            this.groupsService = groupsService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}