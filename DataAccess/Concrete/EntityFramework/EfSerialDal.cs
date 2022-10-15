﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSerialDal : ISerialDal
    {
        public void Add(Serial entity)
        {
            using (var context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Serial entity)
        {
            using (var context = new RentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Serial Get(Expression<Func<Serial, bool>> filter)
        {
            using (var context = new RentACarContext())
            {
                var result = context.Set<Serial>().SingleOrDefault(filter);
                return result;
            }
        }

        public List<Serial> GetAll(Expression<Func<Serial, bool>> filter = null)
        {
            using (var context = new RentACarContext())
            {
                return filter == null
                    ? context.Set<Serial>().ToList()
                    : context.Set<Serial>().Where(filter).ToList();
            }
        }

        public void Update(Serial entity)
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
