using CleanArcProject.Domain.Models;

namespace CleanArcProject.Application.ViewModels.Categories
{
    public class CategoryListViewModel
    {
        public string Name { get; set; }
        public IEnumerable<Products> products { get; set; }
    }
}
