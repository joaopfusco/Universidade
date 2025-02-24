﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Universidade.Domain.Models;

namespace Universidade.Service.Interfaces
{
    public interface IBaseService<TModel> where TModel : BaseModel
    {
        IQueryable<TModel> Get(Expression<Func<TModel, bool>>? predicate = null);

        IQueryable<TModel> Get(int id);

        int Insert(TModel model);

        int Update(TModel model);

        int Delete(int id);
    }
}
