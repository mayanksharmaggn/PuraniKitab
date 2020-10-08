﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PuraniKitab.DataAccess.Data.Repository.IRepository
{
     public interface IRepository<T> where T:class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> Filter=null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby=null,
            string includeProperties= null
            );

        T GetFirstOrDefault(
           Expression<Func<T, bool>> Filter = null,
           
           string includeProperties = null
           );

        void Add(T entity);

        void Remove(T entity);

        void Remove(int id);
        void RemoveRange(IEnumerable<T> entity);
    }
}
