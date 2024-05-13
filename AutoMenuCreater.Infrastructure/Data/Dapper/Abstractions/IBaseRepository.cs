using AutoMenuCreater.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data.Abstractions
{
    public interface IBaseRepository<TPrimaryKey, TEntity> where TEntity : IEntity<TPrimaryKey>
    {
        Task<TEntity> GetAsync(TPrimaryKey id);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> match);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }

    public interface IBaseRepository<TEntity> : IBaseRepository<int, TEntity> where TEntity : IEntity<int>
    {

    }
}
