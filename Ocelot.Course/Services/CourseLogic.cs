using Ocelot.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocelot.CourseService.Services
{
    public class CourseLogic : ICourseLogic
    {
        public async Task<List<CourseModel>> CourseList()
        {
            List<CourseModel> courses = new List<CourseModel>();
            courses.Add(new CourseModel()
            {
                Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                AuthorId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                Title = "Overthrowing Mutiny",
                Description = "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny."

            });
            courses.Add(new CourseModel()
            {
                Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                AuthorId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                Title = "Avoiding Brawls While Drinking as Much Rum as You Desire",
                Description = "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk."
            });

            return courses;

        }
    }
}
