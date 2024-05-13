using AutoMenuCreater.Business.Dto.Request.MenuType;
using AutoMenuCreater.Business.Dto.Response.MenuType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Contracts
{
	public interface IMenuTypesService
	{
		Task<IEnumerable<MenuTypeGetDto>> GetAll();
		Task<MenuTypeGetDto> Find(int id);
		Task<bool> Delete(int id);
		Task<int> Save(MenuTypeSaveDto dto);
	}
}
