﻿using Microsoft.AspNetCore.Mvc;
using Students.Core.Services;

namespace AngularAspNetSample.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}