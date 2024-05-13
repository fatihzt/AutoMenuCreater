using AutoMenuCreater.Data.Models;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Abstractions
{
	public interface IProductsRepository : IMustHaveSetStorageContext
	{
		Task<Product> Add(Product entity);
		Task<bool> Update(Product entity);
		Task<bool> Delete(Product entity);
		Task<IEnumerable<Product>> GetAll();
		Task<Product> Find(int id);
	}
}
