using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repository.UnitOfWork
{
	public interface IUnitOfWork
	{
		int Commit();
	}
}
