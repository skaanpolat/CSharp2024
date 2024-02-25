using KodlamaIOCCC.Business.Concretes;
using KodlamaIOCCC.DataAccess.Concretes;
using KodlamaIOCCC.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        var categoryData = categoryManager.GetAllCategories();

        Console.WriteLine("Kategori Listesi\n");

        foreach (var category in categoryData)
        {
            Console.WriteLine(category.Name);
        }

        CourseManager courseManager = new CourseManager(new CourseDal());
        List<Course> courses = courseManager.GetAllCourses();

        var courseData = courseManager.GetAllCourses();

        Console.WriteLine("-------------------\nDers Listesi\n");

        foreach (var course in courseData)
        {
            Console.WriteLine(course.Name);
        }

        InstructorManager instructorManager = new InstructorManager(new InstructorDal());
        var instructorData = instructorManager.GetAllInstructors();

        Console.WriteLine("-------------------\nEğitmen Listesi\n");

        foreach (var instructor in instructorData)
        {
            Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
        }

    }
}