using CleanArcProject.Application.Interfaces;
using CleanArcProject.Application.Services;
using CleanArcProject.Domain.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArcProject.Infra.Data.Repository;
using AutoMapper;
using CleanArcProject.Application.Profiles;

namespace CleanArcProject.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application layer
            services.AddScoped<IProductsService,ProductService>();
            services.AddScoped<ICategoryService,CategoryService>();
            //infra DATA layer
            services.AddScoped<IProductsRepository,ProductsRepository>();
            services.AddScoped<ICategoriesRepository,CategoryRepository>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
