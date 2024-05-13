using AutoMenuCreater.Data.Models;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Data.Abstractions
{
	public interface IMenuTypesRepository : IMustHaveSetStorageContext
	{
		Task<MenuType> Add(MenuType entity);
		Task<bool> Update(MenuType entity);
		Task<bool> Delete(MenuType entity);
		Task<IEnumerable<MenuType>> GetAll();
		Task<MenuType> Find(int id);

	}
}
