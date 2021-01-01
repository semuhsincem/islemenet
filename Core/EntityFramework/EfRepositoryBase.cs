using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFramework
{
    public class EfRepositoryBase<TContext, TEntity> : IRepository<TEntity> where TEntity : BaseEntity, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry<TEntity>(entity);
                addedEntity.State = EntityState.Added;
                addedEntity.Entity.AtCreated = DateTime.Now;
                addedEntity.Entity.IsActive = true;
                addedEntity.Entity.IsDeleted = false;
                context.SaveChanges();
                return addedEntity.Entity;
            }
        }

        public TEntity Delete(int id)
        {
            using (var context = new TContext())
            {
                var result = context.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();
                var addedEntity = context.Entry<TEntity>(result);
                addedEntity.State = EntityState.Modified;
                addedEntity.Entity.AtDeleted = DateTime.Now;
                addedEntity.Entity.IsDeleted = true;
                context.SaveChanges();
                return addedEntity.Entity;
            }
        }

        public TEntity Get(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression != null ? context.Set<TEntity>().Where(x=>!x.IsDeleted).Where(expression).ToList() : context.Set<TEntity>().Where(x => !x.IsDeleted).ToList();
            }
        }

        public IQueryable<TEntity> GetListQueryable(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression != null ? context.Set<TEntity>().Where(expression) : context.Set<TEntity>();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                 
                var updatedEntity = context.Entry<TEntity>(entity);
                updatedEntity.State = EntityState.Modified;
                updatedEntity.Entity.AtModified = DateTime.Now;
                context.SaveChanges();
                return updatedEntity.Entity;
            }
        }
    }
}
