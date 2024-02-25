using System;
using KodlamaIOCCC.Business.Abstracts;
using KodlamaIOCCC.DataAccess.Concretes;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Concretes
{
	public class CourseManager : ICourseService
	{
        private CourseDal _courseDal;

		public CourseManager(CourseDal courseDal)
		{
            _courseDal = courseDal;
		}

        public List<Course> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }
    }
}

