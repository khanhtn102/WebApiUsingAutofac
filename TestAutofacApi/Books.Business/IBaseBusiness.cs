using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Business
{
	public interface IBaseBusiness<T> : IBusiness where T : class
	{
		IQueryable<T> GetAll();
		void Create(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
