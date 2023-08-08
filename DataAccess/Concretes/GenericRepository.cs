using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var context = new YurtOtomasyonContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new YurtOtomasyonContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new YurtOtomasyonContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new YurtOtomasyonContext();
            return context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using var context = new YurtOtomasyonContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
