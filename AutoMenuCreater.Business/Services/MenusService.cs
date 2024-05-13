using AutoMenuCreater.Business.Contracts;
using AutoMenuCreater.Business.Dto.Request.Menu;
using AutoMenuCreater.Business.Dto.Response.Menu;
using AutoMenuCreater.Core.Exceptions;
using AutoMenuCreater.Core.Microservice.Abstractions;
using AutoMenuCreater.Core.Microservice.Mapper;
using AutoMenuCreater.Core.Service;
using AutoMenuCreater.Data.Abstractions;
using AutoMenuCreater.Data.Models;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Services
{
	public class MenusService : BaseService, IMenusService
	{
        private readonly IMenusRepository repo;
        public MenusService(IMapper mapper, IStorage storage, IUser user) : base(mapper, storage, user)
		{
            repo = storage.GetRepository<IMenusRepository>();
        }

		public async Task<bool> Delete(int id)
		{
			var result = await repo.Find(id);
			if(result == null) return false;

			var response = await repo.Delete(result);
			return response;
		}

		public async Task<MenuGetDto> Find(int id)
		{
			var result = await repo.Find(id);
			if (result == null) throw new ObjectNotFoundException("Entity not found!");
			
			var response = mapper.Map<Menu, MenuGetDto>(result);
			return response;

		}

		public async Task<IEnumerable<MenuGetDto>> GetAll()
		{
			var result = await repo.GetAll();
			if (result == null) throw new ObjectNotFoundException();

			var response = mapper.Map<IEnumerable<Menu>, IEnumerable<MenuGetDto>>(result);
			return response;
		}

		public async Task<int> Save(MenuSaveDto dto)
		{
			var entity = mapper.Map<MenuSaveDto, Menu>(dto);

			var result = await repo.Add(entity);
			return result.Id;
		}
	}
}
