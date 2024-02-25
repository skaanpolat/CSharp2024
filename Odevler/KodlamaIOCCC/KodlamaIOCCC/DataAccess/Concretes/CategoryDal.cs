using System;
using KodlamaIOCCC.DataAccess.Abstracts;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            Category category1 = new Category { Id = 1, Name = "Programlama" };
            Category category2 = new Category { Id = 2, Name = "Tasarım" };
            Category category3 = new Category { Id = 3, Name = "UX/UI" };

            _categories = new List<Category> { category1, category2, category3 };

        }

        public List<Category> GetAllCategories()
        {
            return _categories;
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public void Update(Category category)
        {
            var item = _categories.FirstOrDefault(c => c.Id == category.Id) ;

            item = category;
            
        }

    }
}

