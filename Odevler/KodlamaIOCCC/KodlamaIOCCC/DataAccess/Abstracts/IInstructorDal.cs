using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Abstracts
{
	public interface IInstructorDal
	{
        List<Instructor> GetAllInstructors();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
    }
}

