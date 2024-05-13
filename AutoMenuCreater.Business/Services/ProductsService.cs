using AutoMenuCreater.Business.Contracts;
using AutoMenuCreater.Business.Dto.Request.Product;
using AutoMenuCreater.Business.Dto.Response.Product;
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
	public class ProductsService : BaseService, IProductsService
	{
		private readonly IProductsRepository repo;
        public ProductsService(IMapper mapper, IStorage storage, IUser user) : base(mapper, storage, user)
		{
			repo = storage.GetRepository<IProductsRepository>();
		}
		public async Task<bool> Delete(int id)
		{
			var result = await repo.Find(id);
			if (result == null) return false;

			var response = await repo.Delete(result);
			return response;
		}

		public async Task<ProductGetDto> Find(int id)
		{
			var result = await repo.Find(id);
			if (result == null) throw new ObjectNotFoundException("Entity not found!");

			var response = mapper.Map<Product, ProductGetDto>(result);
			return response;
		}

		public async Task<IEnumerable<ProductGetDto>> GetAll()
		{
			var result = await repo.GetAll();
			if (result == null) throw new ObjectNotFoundException();

			var response = mapper.Map<IEnumerable<Product>, IEnumerable<ProductGetDto>>(result);
			return response;
		}

		public async Task<int> Save(ProductSaveDto dto)
		{
			var entity = mapper.Map<ProductSaveDto, Product>(dto);

			var result = await repo.Add(entity);
			return result.Id;
		}
	}
}
