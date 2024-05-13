using AutoMenuCreater.Infrastructure.Data.Abstractions;
using AutoMenuCreater.Infrastructure.Data.Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data
{
	public abstract class StorageContextBase : IStorageContext
	{
		/// <summary>
		/// The connection string that is used to connect to the physical storage.
		/// </summary>
		public string ConnectionString { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="StorageContext">StorageContext</see> class.
		/// </summary>
		/// <param name="connectionStringProvider">The connection string that is used to connect to the physical storage.</param>
		public StorageContextBase(IOptions<StorageContextOptions> options)
		{
			this.ConnectionString = options.Value.ConnectionString;
		}

		public abstract Task<T> ExecuteScalarAsync<T>(string query, object parameters = null);

		public abstract Task<object> ExecuteScalarToObjectAsync(string query, object parameters = null);

		public abstract Task<int> ExecuteStoredProcedureAsync(string procedure, object parameters = null);

		public abstract bool CheckConnection();

		public abstract Task<int> ExecuteQueryAsync(string query);

		public abstract Task<IEnumerable<T>> SpQueryAsync<T>(string query, object parameters = null);

		public abstract Task<IEnumerable<T>> QueryAsync<T>(string query, object parameters = null);

		public abstract Task<int> AddAsync<T>(T entity) where T : class;

		public abstract Task<bool> UpdateAsync<T>(T entity) where T : class;

		public abstract Task<bool> DeleteAsync<T>(T entity) where T : class;
	}
}
