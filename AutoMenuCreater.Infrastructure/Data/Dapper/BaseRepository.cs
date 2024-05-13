using AutoMenuCreater.Infrastructure.Data.Abstractions;
using AutoMenuCreater.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data.Dapper
{
    public abstract class BaseRepository<TEntity> : IMustHaveSetStorageContext where TEntity : class, IEntity
    {
        protected StorageContextBase storageContext;
        protected string connectionString;

        /// <summary>
        /// Sets the Dapper storage context that represents the physical storage to work with.
        /// </summary>
        /// <param name="storageContext">The Dapper storage context to set.</param>
        public void SetStorageContext(IStorageContext storageContext)
        {
            this.storageContext = (StorageContextBase)storageContext;
            connectionString = ((StorageContextBase)storageContext).ConnectionString;
        }

        public virtual async Task<T> ExecuteScalarAsync<T>(string query, object param = null)
        {
            return await storageContext.ExecuteScalarAsync<T>(query, param);
        }

        public virtual async Task<object> ExecuteScalarToObjectAsync(string query, object param = null)
        {
            return await storageContext.ExecuteScalarToObjectAsync(query, param);
        }

        public virtual async Task<int> ExecuteQueryAsync(string query)
        {
            return await storageContext.ExecuteQueryAsync(query);
        }

        public virtual async Task<int> ExecuteStoredProcedureAsync(string procedure, object parameters = null)
        {
            return await storageContext.ExecuteStoredProcedureAsync(procedure, parameters);
        }

        public virtual async Task<IEnumerable<T>> SpQueryAsync<T>(string procedure, object parameters = null)
        {
            return await storageContext.SpQueryAsync<T>(procedure, parameters);
        }

        public virtual async Task<IEnumerable<T>> QueryAsync<T>(string query, object parameters = null)
        {
            return await storageContext.QueryAsync<T>(query, parameters);
        }

        public virtual async Task<int> AddAsync(TEntity entity)
        {
            return await storageContext.AddAsync(entity);
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            return await storageContext.UpdateAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync(TEntity entity)
        {
            return await storageContext.DeleteAsync(entity);
        }
    }

}
