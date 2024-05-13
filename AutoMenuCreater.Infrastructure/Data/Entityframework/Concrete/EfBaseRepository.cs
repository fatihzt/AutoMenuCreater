using AutoMenuCreater.Infrastructure.Data.Entityframework.Abstractions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using AutoMenuCreater.Infrastructure.Entity;
using AutoMenuCreater.Core.Helper;

namespace AutoMenuCreater.Core.Data.Entityframework.Concrete
{
	public abstract class EfBaseRepository<TEntity> : IMustHaveSetStorageContext, IBaseRepository<TEntity> where TEntity : Entity
	{

		protected DbContext _dbContext;
		protected DbSet<TEntity> dbSet;

		public void SetStorageContext(IStorageContext storageContext)
		{
			_dbContext = storageContext as DbContext;
			dbSet = _dbContext.Set<TEntity>();
		}

		public TEntity Get(int id)
		{
			return dbSet.Find(id);
		}

		public async Task<TEntity> AddAsync(TEntity entity)
		{
			var result = await dbSet.AddAsync(entity);
			return result.Entity;
		}

		public async Task<bool> DeleteAsync(TEntity entity)
		{
			var deletedEntity = _dbContext.Entry(entity);
			deletedEntity.State = EntityState.Deleted;
			bool value = _dbContext.SaveChanges() > 0;
			return value;
		}

		public async Task RemoveAsync(int entity)
		{
			Ensure.Argument.NotNull(entity, "entity");
			var item = Get(entity);
			Ensure.Argument.NotNull(item, "item");

			_dbContext.Set<TEntity>().Remove(item);
			await CommitAsync();
		}

		public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
		{
			return await dbSet.Where(match).ToListAsync();
		}

		public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
		{
			return await dbSet.SingleOrDefaultAsync(match);
		}

		public async Task<TEntity> GetAsync(int id)
		{
			return await dbSet.FindAsync(id);
		}

		public async Task<bool> UpdateAsync(TEntity entity)
		{
			var modifiedEntity = _dbContext.Entry(entity);
			modifiedEntity.State = EntityState.Modified;
			bool value = _dbContext.SaveChanges() > 0;
			return value;
		}

		private async Task CommitAsync()
		{
			try
			{
				await _dbContext.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				//LogError(ex.Message);
			}
		}

		public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> match)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<TEntity>> GetAllAsync()
		{
			var query = _dbContext.Set<TEntity>().AsQueryable();
			var result = query.AsEnumerable();
			return result;
		}
	}

}
