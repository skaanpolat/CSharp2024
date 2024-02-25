using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Abstracts
{
	public interface ICourseDal
	{
        List<Course> GetAllCourses();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}

