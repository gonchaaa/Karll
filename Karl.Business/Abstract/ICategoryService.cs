using Karl.Core.Utilities.Results.Abstract;
using Karl.Entities.Concrete;
using Karl.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Business.Abstract
{
    public interface ICategoryService
    {
        IResult AddCategory(CategoryAddDTO category);
        IResult DeleteCategory(Category category);
        IResult UpdateCategory(Category category);
        IDataResult<List<CategoryDetailListDTO>> GetAllCategories(string langcode);
        IDataResult<List<Category>> GetNavbarCategories(string langcode);
    }
}
