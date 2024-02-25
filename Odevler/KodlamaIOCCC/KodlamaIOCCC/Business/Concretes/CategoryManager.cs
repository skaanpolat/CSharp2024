using System;
using KodlamaIOCCC.Business.Abstracts;
using KodlamaIOCCC.DataAccess.Abstracts;
using KodlamaIOCCC.DataAccess.Concretes;
using KodlamaIOCCC.Entities;

namespace KodlamaIOCCC.Business.Concretes
{
	public class CategoryManager : ICategoryService
	{
        private ICategoryDal _categoryDal;
		public CategoryManager(CategoryDal categoryDal)
		{
            _categoryDal = categoryDal;
		}

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAllCategories();
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

