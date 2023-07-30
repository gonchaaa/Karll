using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karl.Core.DataAccess.EntityFrameWork
{
    public class EfRepostoryBase<TEntity, TContext> : IRepostoryBase<TEntity>
       where TEntity : class 
       where TContext : DbContext,new()
    {

        public void Add(TEntity entity)
        {
            using TContext context = new();
            var addEntity=context.Entry(entity);
            addEntity.State = EntityState.Added; 
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
           using TContext context= new();
            var removeEntity = context.Entry(entity);
            removeEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
          using TContext context=new();
           return context.Set<TEntity>().SingleOrDefault(filter);
     
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using TContext context = new();
            return filter==null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            using TContext context = new();
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
