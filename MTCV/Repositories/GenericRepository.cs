using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MTCV.Models.ENTITY;

namespace MTCV.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        ContextCv db = new ContextCv();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find();
        }
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> filter)
        {
            return db.Set<T>().FirstOrDefault(filter);
        }
    }
}