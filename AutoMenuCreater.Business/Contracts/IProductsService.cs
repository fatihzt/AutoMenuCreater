using AutoMenuCreater.Business.Dto.Request.Product;
using AutoMenuCreater.Business.Dto.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Business.Contracts
{
	public interface IProductsService
	{
		Task<IEnumerable<ProductGetDto>> GetAll();
		Task<ProductGetDto> Find(int id);
		Task<bool> Delete(int id);
		Task<int> Save(ProductSaveDto dto);
	}
}
