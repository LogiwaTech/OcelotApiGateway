using Microsoft.AspNetCore.Mvc;
using Ocelot.CourseService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocelot.Course.Controllers
{
    [ApiController]
    [Route("api/course")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseLogic _courseLogic;

        public CourseController(ICourseLogic courseLogic)
        {
            _courseLogic = courseLogic;
        }
        [HttpGet]
        public async Task<List<CourseModel>> GetCourseList()
        {
            return await _courseLogic.CourseList();
        }
    }
}
