using CleanArcProject.Domain.Models;
using CleanArcProject.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Application.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<ProductsListViewModel> GetAllProducts();
        Products GetProduct(int id);
        void AddProduct(CreateProductsViewModel product);
        bool EditProduct(EditProductsViewModel product);
        void DeleteProduct(Products product);
        bool DeleteProduct(int Id);
        void DeleteAllProducts();
    }
}
