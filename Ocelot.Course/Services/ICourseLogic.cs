using Ocelot.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocelot.CourseService.Services
{
    public interface ICourseLogic
    {
        Task<List<CourseModel>> CourseList();
    }
}
