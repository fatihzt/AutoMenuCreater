using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoMenuCreater.Infrastructure.Data.Entityframework.Abstractions
{
	public interface IEntityRepository<T> where T : class
		// It indicates that the type T can only be classes.
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includesPath = null);//With this filter parameter, when we call the method, we can retrieve only the entities from the table that meet specific conditions.
		T Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> includesPath = null);
		int Add(T entity);
		bool Delete(T entity);
		bool Update(T entity);
	}
}
