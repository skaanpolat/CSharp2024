using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.Business;

public class CourseManager
{
    //Dependency Injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> getAll()
	{
        //Business rules

        return _courseDal.GetAll();

	}
}

