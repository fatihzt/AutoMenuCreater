using AutoMenuCreater.Core.Data.Entityframework.Concrete;
using AutoMenuCreater.Data.Abstractions;
using AutoMenuCreater.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Repositories
{
	public class MenuTypesRepository : EfBaseRepository<MenuType>, IMenuTypesRepository
	{
		public async Task<MenuType> Add(MenuType entity)
		{
			var result = await AddAsync(entity);
			return result;
		}

		public async Task<bool> Delete(MenuType entity)
		{
			var result = await DeleteAsync(entity);
			return result;
		}

		public async Task<MenuType> Find(int id)
		{
			var result = await FindAsync(entity => entity.Id == id);
			return result;
		}

		public async Task<IEnumerable<MenuType>> GetAll()
		{
			var result = await GetAllAsync();
			return result;
		}

		public async Task<bool> Update(MenuType entity)
		{
			var result = await UpdateAsync(entity);
			return result;
		}
	}
}
