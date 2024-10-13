using Microsoft.AspNetCore.Mvc;

namespace AngularAspNetSample.Server.Controllers
{
    public abstract class StudentsControllerBase : ControllerBase
    {
        protected ActionResult HandleException(Exception e) => 
            StatusCode(
                StatusCodes.Status500InternalServerError,
                new { message = "An unexpected error occurred.", details = e.Message }
            );
    }
}