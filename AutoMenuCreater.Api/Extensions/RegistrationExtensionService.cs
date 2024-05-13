using AutoMenuCreater.Business.Contracts;
using AutoMenuCreater.Business.Services;
using AutoMenuCreater.Data.Abstractions;
using AutoMenuCreater.Data.Repositories;
using System.ComponentModel.Design;

namespace AutoMenuCreater.Api.Extensions
{
	public static class RegistrationExtensionService
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddScoped<IMenusRepository, MenusRepository>();
			services.AddScoped<IMenuTypesRepository,MenuTypesRepository>();
			services.AddScoped<IProductsRepository, ProductsRepository>();
			services.AddScoped<IMenusService,MenusService>();
			services.AddScoped<IMenuTypesService,MenuTypesService>();
			services.AddScoped<IProductsService,ProductsService>();
		}
	}
}
