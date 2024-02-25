using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Abstracts;

public interface IInstructorService
{
    List<Instructor> GetAllInstructors();
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}

