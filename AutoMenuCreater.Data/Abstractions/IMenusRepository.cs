using AutoMenuCreater.Data.Models;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Abstractions
{
	public interface IMenusRepository : IMustHaveSetStorageContext
	{
		Task<Menu> Add(Menu entity);
		Task<bool> Update(Menu entity);
		Task<bool> Delete(Menu entity);
		Task<IEnumerable<Menu>> GetAll();
		Task<Menu> Find(int id);
	}
}
