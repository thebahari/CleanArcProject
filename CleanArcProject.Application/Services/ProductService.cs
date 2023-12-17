using CleanArcProject.Application.Interfaces;
using CleanArcProject.Domain.Interface;
using CleanArcProject.Domain.Models;
using CleanArcProject.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Application.Services
{

    public class ProductService : IProductsService
    {
        private readonly IProductsRepository productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        public void AddProduct(CreateProductsViewModel product)
        {
            productsRepository.Add(product);
        }

        public void DeleteAllProducts()
        {
            productsRepository.DeleteAll();
        }

        public void DeleteProduct(Products product)
        {
            productsRepository.Delete(product);
        }

        public bool DeleteProduct(int Id)
        {
           return productsRepository.Delete(Id);
        }

        public bool EditProduct(EditProductsViewModel product)
        {
           return productsRepository.Edit(product);
        }

        public IEnumerable<ProductsListViewModel> GetAllProducts()
        {
           return productsRepository.GetAll();
        }

        public Products GetProduct(int id)
        {
            return productsRepository.Get(id);
        }
    }
}
