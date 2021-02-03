using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Veri kaynağı ile ilişkilendir.
                addedEntity.State = EntityState.Added; // Ekleme işlemini yap
                context.SaveChanges(); // Ve veri tabanına eklettik.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); // Veri kaynağı ile ilişkilendir.
                deletedEntity.State = EntityState.Deleted; // silme işlemini yap
                context.SaveChanges(); // Ve veri tabanına eklettik.
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); // Veri kaynağı ile ilişkilendir.
                updatedEntity.State = EntityState.Modified; // güncelleme işlemini yap
                context.SaveChanges(); // Ve veri tabanına eklettik.
            }
        }
    }
}
