
using AutoMapper;
using CleanArcProject.Application.Interfaces;
using CleanArcProject.Application.ViewModels.Categories;
using CleanArcProject.Domain.Interface;
using CleanArcProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoriesRepository categoriesRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoriesRepository categoriesRepository,IMapper mapper)
        {
            this.categoriesRepository = categoriesRepository;
            this.mapper = mapper;
        }
        public bool DeleteAllCategories()
        {
            return categoriesRepository.DeleteAll();
        }

        public void DeleteCategory(int Id)
        {
            categoriesRepository.Delete(Id);
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return categoriesRepository.GetAll();
        }

        public CategoriesViewModels GetCategoryById(int Id)
        {
            var result= categoriesRepository.GetById(Id);
            return mapper.Map<CategoriesViewModels>(result);
        }
        public Categories GetCategory(int Id)
        {
           return categoriesRepository.GetById(Id);
            
        }

        public void InsertCategory(Categories category)
        {
            categoriesRepository.Add(category);
        }

        public void UpdateCategory(Categories category)
        {
            categoriesRepository.Update(category);
        }
    }
}
