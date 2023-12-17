using CleanArcProject.Application.ViewModels.Categories;
using CleanArcProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Application.Interfaces
{
    public interface ICategoryService
    {
        Categories GetCategory(int Id);
        IEnumerable<Categories> GetAllCategories();
        CategoriesViewModels GetCategoryById(int Id);
        void DeleteCategory(int Id);
        void InsertCategory(Categories category);
        void UpdateCategory(Categories category);
        bool DeleteAllCategories();
    }
}
