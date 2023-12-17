using CleanArcProject.Domain.Models;
using CleanArcProject.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Domain.Interface
{
    public interface IProductsRepository
    {
        IEnumerable<ProductsListViewModel> GetAll();
        Products Get(int id);
        void Add(CreateProductsViewModel product);
        bool Edit(EditProductsViewModel product);
        void Delete(Products product);
        bool Delete(int Id);
        void DeleteAll();

    }
}
