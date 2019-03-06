using Domain.Driven.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Driven.Infrastructure.Repository
{
    public class RepositorySqlServer<TEntity> : RepositorySqlServer<int, TEntity>
        where TEntity : class
    {
    }

    public class RepositorySqlServer<TPrimary, TEntity> : IRepository<TPrimary, TEntity>
        where TPrimary : struct where TEntity : class
    {
        public TEntity GetByPrimary(TPrimary primary)
        {
            throw new NotImplementedException();
        }

        public TPrimary Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
