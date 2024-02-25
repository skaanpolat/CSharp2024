using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Abstracts;

public interface ICategoryService
{
    List<Category> GetAllCategories();
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
}

