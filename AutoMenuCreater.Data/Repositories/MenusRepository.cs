using AutoMenuCreater.Core.Data.Entityframework.Concrete;
using AutoMenuCreater.Data.Abstractions;
using AutoMenuCreater.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Repositories
{
	public class MenusRepository : EfBaseRepository<Menu>, IMenusRepository
	{
		public async Task<Menu> Add(Menu entity)
		{
			var result = await AddAsync(entity);
			return result;
		}

		public async Task<bool> Delete(Menu entity)
		{
			var result = await DeleteAsync(entity);
			return result;
		}

		public async Task<Menu> Find(int id)
		{
			var result = await FindAsync(entity => entity.Id == id);
			return result;
		}

		public async Task<IEnumerable<Menu>> GetAll()
		{
			var result = await GetAllAsync();
			return result;
		}

		public async Task<bool> Update(Menu entity)
		{
			var result = await UpdateAsync(entity);
			return result;
		}
	}
}
