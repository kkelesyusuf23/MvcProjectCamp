﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T>  
    {
        List<T> List();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}