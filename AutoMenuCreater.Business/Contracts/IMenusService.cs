using AutoMenuCreater.Business.Dto.Request.Menu;
using AutoMenuCreater.Business.Dto.Response.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Contracts
{
	public interface IMenusService
	{
		Task<IEnumerable<MenuGetDto>> GetAll();
		Task<MenuGetDto> Find(int id);
		Task<bool> Delete(int id);
		Task<int> Save(MenuSaveDto dto);
	}
}
