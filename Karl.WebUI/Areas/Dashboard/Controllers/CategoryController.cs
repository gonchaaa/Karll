using Karl.Business.Abstract;
using Karl.Entities.Concrete;
using Karl.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Karl.WebUI.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAddDTO categoryAddDTO)
        {
           var result= _categoryService.AddCategory(categoryAddDTO);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return View(categoryAddDTO);
        }
    }
    }

