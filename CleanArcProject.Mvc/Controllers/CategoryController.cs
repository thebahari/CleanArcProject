using AutoMapper;
using CleanArcProject.Application.Interfaces;
using CleanArcProject.Application.ViewModels.Categories;
using CleanArcProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcProject.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var result = categoryService.GetAllCategories();
            return View(result);
        }
        public void Insert()
        {
            var model = new Categories()
            {
               Name = "shiraz",
               Description = "thid is shiraz",
               IsDeleted = false
            };
            categoryService.InsertCategory(model);
            
        }
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var result=categoryService.GetCategoryById(id);
        //    return View(result);

        //}
        //[HttpPost]
        //public IActionResult Edit(CategoriesViewModels models)
        //{
        //    var c=categoryService.GetCategory(models.Id);
        //    var result=mapper.Map(models,c);
        //    categoryService.UpdateCategory(result);
        //    return View();
        //}
    }
}
