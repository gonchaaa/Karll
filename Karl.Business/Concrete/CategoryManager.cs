using Karl.Business.Abstract;
using Karl.Core.Utilities.Results.Abstract;
using Karl.Core.Utilities.Results.Concrete;
using Karl.DataAccess.Abstract;
using Karl.Entities.Concrete;
using Karl.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult AddCategory(CategoryAddDTO category)
        {
            try
            {
                
            _categoryDal.AddCategory(category);
              return new SuccesResult("Category is added");

            }
            catch (Exception ex) 
            {
                return new ErrorResult(ex.Message);

            }

        }

        public IResult DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryDetailListDTO>> GetAllCategories(string langcode)
        {
            var result= _categoryDal.GetCategoriesByLanguage(langcode);
            return new SuccessDataResult<List<CategoryDetailListDTO>>(result);
        }

        public IDataResult<List<Category>> GetNavbarCategories(string langcode)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
