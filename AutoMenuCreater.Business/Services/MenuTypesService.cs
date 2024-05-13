using AutoMenuCreater.Business.Contracts;
using AutoMenuCreater.Business.Dto.Request.MenuType;
using AutoMenuCreater.Business.Dto.Response.MenuType;
using AutoMenuCreater.Core.Exceptions;
using AutoMenuCreater.Core.Microservice.Abstractions;
using AutoMenuCreater.Core.Microservice.Mapper;
using AutoMenuCreater.Core.Service;
using AutoMenuCreater.Data.Abstractions;
using AutoMenuCreater.Data.Models;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Services
{
	public class MenuTypesService : BaseService, IMenuTypesService
	{
		private readonly IMenuTypesRepository repo;
        public MenuTypesService(IMapper mapper, IStorage storage, IUser user) : base(mapper, storage, user)
		{
			repo = storage.GetRepository<IMenuTypesRepository>();
		}
		public async Task<bool> Delete(int id)
		{
			var result = await repo.Find(id);
			if (result == null) return false;

			var response = await repo.Delete(result);
			return response;
		}

		public async Task<MenuTypeGetDto> Find(int id)
		{
			var result = await repo.Find(id);
			if (result == null) throw new ObjectNotFoundException("Entity not found!");

			var response = mapper.Map<MenuType, MenuTypeGetDto>(result);
			return response;
		}

		public async Task<IEnumerable<MenuTypeGetDto>> GetAll()
		{
			var result = await repo.GetAll();
			if (result == null) throw new ObjectNotFoundException();

			var response = mapper.Map<IEnumerable<MenuType>, IEnumerable<MenuTypeGetDto>>(result);
			return response;
		}

		public async Task<int> Save(MenuTypeSaveDto dto)
		{
			var entity = mapper.Map<MenuTypeSaveDto, MenuType>(dto);

			var result = await repo.Add(entity);
			return result.Id;
		}
	}
}
