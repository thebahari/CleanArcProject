using CleanArcProject.Application.Interfaces;
using CleanArcProject.Application.Services;
using CleanArcProject.Application.ViewModels.Profiles;
using CleanArcProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcProject.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }
        public IActionResult Index()
        {
            var result=productsService.GetAllProducts();
            return View(result);
        }
        public void Insert()
        {
            var model = new Domain.ViewModel.CreateProductsViewModel()
            {
                Name = "Iphon",
                Description = "this is phone",
                CategoryId = 1
            };
            productsService.AddProduct(model);
        }
    }
}
