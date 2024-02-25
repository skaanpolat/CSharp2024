using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Abstracts;

public interface ICourseService
{
    List<Course> GetAllCourses();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}

