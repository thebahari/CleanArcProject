using CleanArcProject.Domain.Interface;
using CleanArcProject.Domain.Models;
using CleanArcProject.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Infra.Data.Repository
{
    public class CategoryRepository : ICategoriesRepository
    {
        private readonly DbCleanArcProject db;

        public CategoryRepository(DbCleanArcProject db)
        {
            this.db = db;
        }
        public void Add(Categories category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            //delete category with id
            //حذف فیزیکی
            //db.Categories.Remove(new Categories { Id = Id });
            //حذف منطقی
            var category = db.Categories.Find(Id);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        public bool DeleteAll()
        {
            try
            {
                var categories = db.Categories.ToList();
                categories.ForEach(x =>
                {
                    db.Categories.Remove(x);
                    db.SaveChanges();
                }
                );
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Categories> GetAll()
        {
            //return all categories
            return db.Categories.ToList();
        }

        public Categories GetById(int Id)
        {

            var category = db.Categories.Find(Id);
            if (category != null)
            {
                return category;
            }
            return null;

        }

        public void Update(Categories category)
        {
            var c = db.Categories.Find(category.Id);
            if (c != null)
            {
                c.Id=category.Id;
                c.Name=category.Name;
                c.Description=category.Description;
                c.IsDeleted=category.IsDeleted;
                db.Categories.Update(c);
                db.SaveChanges();
            }
        }
    }
}
