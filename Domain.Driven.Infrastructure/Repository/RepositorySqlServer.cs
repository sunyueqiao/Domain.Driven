using Dapper.Extend;
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

    public class RepositorySqlServer<TPrimary, TEntity> : SqlServerDal<TPrimary, TEntity>,
        IRepository<TPrimary, TEntity>
        where TPrimary : struct
        where TEntity : class
    {
        private static string ConnectionString
        {
            get
            {
                return string.Empty;
            }
        }

        public RepositorySqlServer() : base(ConnectionString)
        {
        }
    }
}
