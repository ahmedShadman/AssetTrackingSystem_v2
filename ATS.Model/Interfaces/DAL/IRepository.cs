﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Interfaces
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entity);
        bool Remove(T entity);
        bool Update(T entity);
        T GetById(int id);
        ICollection<T> GetAll(Expression<Func<T, bool>> predicateExpression);
    }
}
