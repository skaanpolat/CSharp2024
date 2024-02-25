using System;
using KodlamaIOCCC.DataAccess.Abstracts;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> _courses;

    public CourseDal()
    {
        Course course1 = new Course { Id = 1, CategoryId = 1, InstructorId = 1, Name = "Programlamaya Giriş İçin Temel Kurs", Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.", Price = 0 };
        Course course2 = new Course { Id = 2, CategoryId = 1, InstructorId = 1, Name = "Java 2022", Price = 0, Description = "Yarım kaldı.." };
        Course course3 = new Course { Id = 3, CategoryId = 1, InstructorId = 2, Name = "Python & Selenium 2023", Price = 0, Description = "Sıfırdan başlayıp yepyeni bir metodolojiyle profesyonelleşeceksiniz" };

        _courses = new List<Course> { course1, course2, course3 };
    }

    public List<Course> GetAllCourses()
    {
        return _courses;
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public void Update(Course course)
    {
        var item = _courses.FirstOrDefault(c => c.Id == course.Id);

        item = course;
    }

}

