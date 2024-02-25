using System;
using KodlamaIOCCC.Business.Abstracts;
using KodlamaIOCCC.DataAccess.Concretes;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Concretes
{
	public class InstructorManager : IInstructorService
	{
        private InstructorDal _instructorDal;

        public InstructorManager(InstructorDal instructorDal)
		{
            _instructorDal = instructorDal;
		}

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _instructorDal.GetAllInstructors();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
    }
}

