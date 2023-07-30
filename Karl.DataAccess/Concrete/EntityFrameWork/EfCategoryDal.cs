using Karl.Core.DataAccess.EntityFrameWork;
using Karl.DataAccess.Abstract;
using Karl.Entities.Concrete;
using Karl.Entities.DTOs.CategoryDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karl.DataAccess.Concrete.EntityFrameWork
{
    public class EfCategoryDal : EfRepostoryBase<Category,AppDbContext>,ICategoryDal
    {
        public async Task<bool> AddCategory(CategoryAddDTO categoryAddDTO)
        {
            try
            {
                using var context = new AppDbContext();
                var category = new Category()
                {
                    PhotoUrl=categoryAddDTO.PhotoUrl,
                    IsFeatured=false
                };


                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                for (int i = 0; i < categoryAddDTO.CategoryName.Count; i++)
                {
                    CategoryLanguage cl = new()
                    {
                        CategoryName = categoryAddDTO.CategoryName[i],
                        LangCode = categoryAddDTO.LangCode[i],
                        CategoryId=category.Id,
                        SeoUrl=""
                    };
                    await context.CategoryLanguages.AddAsync(cl);
                }
                await context.SaveChangesAsync();

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<CategoryDetailListDTO> GetCategoriesByLanguage(string langcode)
        {
            using var context = new AppDbContext();
            var result = context.CategoryLanguages
                .Include(z => z.Category)
                .Where(x => x.LangCode == langcode)
                .Select(x=>new CategoryDetailListDTO
                {
                    Id=x.Category.Id,
                    CatgeoryName=x.CategoryName,
                    SeoUrl=x.SeoUrl,
                    PhotoUrl=x.Category.PhotoUrl,
                    ProductCount=0
                } ).ToList();
            return result;
        }
    }
}
