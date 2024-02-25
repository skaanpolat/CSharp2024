using System;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Abstracts
{
	public interface ICategoryDal
	{
        List<Category> GetAllCategories();
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

    }
}

