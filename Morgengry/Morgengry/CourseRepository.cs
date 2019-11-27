using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class CourseRepository
    {
        List<Course> courses = new List<Course>();

        void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course course = new Course(name);
            if (courses.Contains(course))
            {
                foreach (Course course1 in courses)
                {
                    return course1;
                }
            }
            return null;
        }

        public static double GetTotalValue(Course course)
        {
            double price = (course.DurationInMinutes / 60) * 875.0;
            if ((course.DurationInMinutes % 60) >= 0)
            {
                price += 875;
            }
            return price;
        }
    }
}
