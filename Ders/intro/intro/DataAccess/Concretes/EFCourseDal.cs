using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.DataAccess.Concretes;

public class EFCourseDal : ICourseDal
{
    List<Course> courses;

    public EFCourseDal()
    {
        Course course1 = new Course();
        Course course2 = new Course();
        Course course3 = new Course();

        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Price = 0;
        course1.Description = "E.D";

        course2.Id = 2;
        course2.Name = "Java 8";
        course2.Price = 10;
        course2.Description = "E.D Java Spring";

        course3.Id = 3;
        course3.Name = "Go";
        course3.Price = 20;
        course3.Description = "E.D ile ilgisi yok";

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {

        //ÖDEV ! SQL öğren :)

        //Burada db işlemleri yapılır..
        return courses;

    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
