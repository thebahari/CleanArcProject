using CleanArcProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Domain.Interface
{
    public interface ICategoriesRepository
    {
        IEnumerable<Categories> GetAll();
        Categories GetById(int Id);
        void Delete(int Id);
        void Add(Categories category);
        void Update(Categories category);
        bool DeleteAll();
    }
}
