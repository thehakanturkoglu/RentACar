using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfModelDal : IModelDal
    {
        public void Add(Model entity)
        {
            using (var context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Model entity)
        {
            using (var context = new RentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Model Get(Expression<Func<Model, bool>> filter)
        {
            using (var context = new RentACarContext())
            {
                return context.Set<Model>().SingleOrDefault(filter);
            }
        }

        public List<Model> GetAll(Expression<Func<Model, bool>> filter = null)
        {
            using (var context = new RentACarContext())
            {
                return filter == null ? context.Set<Model>().ToList():context.Set<Model>().Where(filter).ToList();
            }
        }

        public void Update(Model entity)
        {
            using (var context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
