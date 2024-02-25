using System;
using intro.Entities;

namespace intro.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();

    void Add(Course course);
}

