using AutoMapper;
using CleanArcProject.Application.ViewModels.Categories;
using CleanArcProject.Application.ViewModels.Profiles;
using CleanArcProject.Domain.Models;
using CleanArcProject.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            #region Category
            CreateMap<CategoriesViewModels, Categories>();
            CreateMap<EditCategoriesViewModels, Categories>();
            CreateMap<Categories,CategoryListViewModel>();
            #endregion
            #region Products
            CreateMap<CreateProductsViewModels,Products>();
            CreateMap<CreateProductsViewModel,Products>();
            CreateMap<EditCategoriesViewModels,Products>();
            CreateMap<Products,ProductsListViewModel>()
                //با استفاده از این دستور میتونیم آیتم هایی که اسمشون باهم متفاوته رو باهم نگاشت کنیم
                .ForMember(dest=>dest.CategoryName,opt=>opt.MapFrom(src=>src.Categories.Name));
            #endregion
        }
    }
}
