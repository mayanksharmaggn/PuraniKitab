using Microsoft.EntityFrameworkCore;
using PuraniKitab.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PuraniKitab.DataAccess.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

         internal DbSet<T> myDbset;
        public Repository( ApplicationDbContext db)
        {
            _db = db;
            this.myDbset = _db.Set<T>();
        }
        public void Add(T entity)
        {
            myDbset.Add(entity);
        }

        public T Get(int id)
        {
         return   myDbset.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> Filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> Filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
