using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Microservice.Mapper
{
	public interface IMapper
	{
		TDestination Map<TSource, TDestination>(TSource source);
	}
}
