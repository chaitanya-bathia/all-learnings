using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.Models;

namespace Udemy.Services
{
    public interface ICourseService : IRepository<Course>
    {
        Task<List<Course>> GetCoursesWithTutorsAndTopics();
        
    }
    public class CourseService :Repository<Course>, ICourseService
    {
        private udemy2437chaitanyaContext dbcontext = new udemy2437chaitanyaContext();
        public CourseService(udemy2437chaitanyaContext context) : base(context)
        {

        }

        public async Task<List<Course>> GetAll()
        {
            var courseList = await base.GetAll();
            return courseList;
        }

        public async Task<Course> GetCourseByID(int id)
        {
            var course = await GetByID(id);
            return course;
        }

        public async Task<Course> AddCourse(Course course)
        {
            var addedCourse = await base.Add(course);
            return addedCourse;
        }

        public async Task<Course> UpdateCourse(int id, Course course)
        {
            var existing = await GetCourseByID(id);

            if (course.CourseName != null || course.CourseName != "" || course.CourseName != existing.CourseName)
            {
                existing.CourseName = course.CourseName;
            }
            if (course.Price != null || course.Price != existing.Price)
            {
                existing.Price = course.Price;
            }
            if (course.SubCategoryId != null || course.SubCategoryId != existing.SubCategoryId)
            {
                existing.SubCategoryId = course.SubCategoryId;
            }

            return (await base.Update(existing));
        }

        public async Task<Course> DeleteCourse(int id)
        {
            return (await base.Delete(id));
        }

        public async Task<List<Course>> GetCoursesWithTutorsAndTopics()
        {
            return await dbcontext.Courses.Include(x => x.Tutor).Include(x=>x.Topics).Include(x=>x.SubCategory).ToListAsync();
        }
    }
}
