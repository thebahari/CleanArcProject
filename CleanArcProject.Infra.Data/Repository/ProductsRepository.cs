using AutoMapper;
using CleanArcProject.Domain.Interface;
using CleanArcProject.Domain.Models;
using CleanArcProject.Domain.ViewModel;
using CleanArcProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Infra.Data.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DbCleanArcProject db;
        private readonly IMapper mapper;

        public ProductsRepository( DbCleanArcProject db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void Add(CreateProductsViewModel product)
        {
            var map = mapper.Map<Products>(product);
            db.Products.Add(map);
            db.SaveChanges();
        }

        public void Delete(Products product)
        {
            var p=db.Products.Find(product.Id);
            if(p != null)
            {
               p.IsDeleted = true;
                db.Update(p);
                db.SaveChanges();
            }
        }

        public bool Delete(int Id)
        {
            var p = db.Products.Find(Id);
            if( p != null )
            {
                p.IsDeleted = true;
                db.Update(p);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public void DeleteAll()
        {
            var p = db.Products.ToList();
            if (p!=null)
            {
                p.ForEach(x =>
                {
                    x.IsDeleted=true;
                    db.Update(x);
                    db.SaveChanges();

                });
            }
        }

        public bool Edit(EditProductsViewModel product)
        {
            try
            {
                var model = mapper.Map<Products>(product);
                var p = db.Products.Find(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Products Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<ProductsListViewModel> GetAll()
        {
            var models=db.Products.Include(x=>x.Categories).AsEnumerable();
            var result = mapper.Map<IEnumerable<ProductsListViewModel>>(models);
            return result;
        }
    }
}
