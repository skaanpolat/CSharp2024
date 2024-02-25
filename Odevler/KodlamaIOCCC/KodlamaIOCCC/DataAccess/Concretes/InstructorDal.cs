using System;
using KodlamaIOCCC.DataAccess.Abstracts;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
    List<Instructor> _instructors;

	public InstructorDal()
	{
        Instructor instructor1 = new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" };
        Instructor instructor2 = new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };
        Instructor instructor3 = new Instructor { Id = 3, FirstName = "Derin", LastName = "Demiroğ" };

        _instructors = new List<Instructor> { instructor1, instructor2, instructor3 };
	}


    public List<Instructor> GetAllInstructors()
    {
        return _instructors;

    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructors.Remove(instructor);
    }


    public void Update(Instructor instructor)
    {
        var item = _instructors.FirstOrDefault(c => c.Id == instructor.Id);

        item = instructor;

    }
}

