using CoreAndFood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T:class,new()
    {
        Context c = new Context();

        public List<T> ListT()
        {
            return c.Set<T>().ToList();
        }

        public List<T> ListT(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }

        public void AddT(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }

        public void DeleteT(T p)
        {
      
            c.Set<T>().Remove(p);
            c.SaveChanges();
        }

        public void UpdateT(T p)
        {
            c.Set<T>().Update(p);
            c.SaveChanges();
        }

        public T GetT(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> List(Expression<Func<T ,bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

    }
}
