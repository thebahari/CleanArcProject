using CleanArcProject.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcProject.Infra.Data.Context
{
    public class DbCleanArcProject:DbContext
    {
        public DbCleanArcProject(DbContextOptions options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DbCleanArcProject;Integrated Security=True");
        //}
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //هرموقغ خواستی لیست محصولات رو نشون بدی اون محصولاتی رو نشون بده
            //که فیلد ایز دیلتد آن فالس باشد.
            modelBuilder.Entity<Products>().HasQueryFilter(a => !a.IsDeleted);
        }
    }
}
