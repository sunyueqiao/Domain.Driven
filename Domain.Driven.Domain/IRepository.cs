using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Domain
{
    public interface IRepository<TEntity> : IRepository<int, TEntity> where TEntity : class
    {
    }

    public interface IRepository<TPrimary, TEntity> where TPrimary : struct
        where TEntity : class
    {
        TPrimary Insert(TEntity entity);

        TEntity GetByPrimary(TPrimary primary);

        void Update(TEntity entity);
    }
}
