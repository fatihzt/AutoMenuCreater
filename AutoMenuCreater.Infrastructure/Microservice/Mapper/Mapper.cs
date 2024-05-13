using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Core.Microservice.Mapper
{
	public class Mapper : IMapper
	{
		public TDestination Map<TSource, TDestination>(TSource source)
		{
			return source.Adapt<TDestination>();
		}
	}
}
