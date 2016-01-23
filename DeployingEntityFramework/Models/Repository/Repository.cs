using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DeployingEntityFramework.Models.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly MusicContext context = null;
        protected DbSet<TEntity> dbSet { get; set; }
        public Repository()
        {
            context = new MusicContext();
            dbSet = context.Set<TEntity>();
        }
        public Repository(MusicContext context)
        {
            this.context = context;
        }

        public virtual List<TEntity> GetAll()
        {
            return dbSet.ToList();
        }
        public virtual bool Add(TEntity entity)
        {
            dbSet.Add(entity);
            return SaveChanges();
        }
        public virtual bool Remove(TEntity entity)
        {
            dbSet.Remove(entity);
            return SaveChanges();
        }
        public virtual TEntity GetByID(int id)
        {
            return dbSet.Find(id);
        }
        public virtual bool Update(TEntity entity)
        {
            context.Entry<TEntity>(entity).State = EntityState.Modified;
            return SaveChanges();
        }
        public virtual bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }        
   
    }
}