using AutoMenuCreater.Core.Microservice.Abstractions;
using AutoMenuCreater.Core.Microservice.Mapper;
using AutoMenuCreater.Infrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Service
{
	public class BaseService
	{
		protected readonly IMapper mapper;
		protected readonly IStorage storage;
		protected readonly IUser user;
		protected readonly string userName;

		public BaseService(IMapper mapper, IStorage storage, IUser user)
		{
			this.mapper = mapper;
			this.storage = storage;
			this.user = user;
			userName = user.GetUserName();
		}
	}
}
