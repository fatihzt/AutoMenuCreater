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
	public class ProductsRepository : EfBaseRepository<Product>, IProductsRepository
	{
		public async Task<Product> Add(Product entity)
		{
			var result = await AddAsync(entity);
			return result;
		}

		public async Task<bool> Delete(Product entity)
		{
			var result = await DeleteAsync(entity);
			return result;
		}

		public async Task<Product> Find(int id)
		{
			var result = await FindAsync(entity => entity.Id == id);
			return result;
		}

		public async Task<IEnumerable<Product>> GetAll()
		{
			var result = await GetAllAsync();
			return result;
		}

		public async Task<bool> Update(Product entity)
		{
			var result = await UpdateAsync(entity);
			return result;
		}
	}
}
