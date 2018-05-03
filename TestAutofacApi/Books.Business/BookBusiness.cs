using Books.Model;
using Books.Repository;
using Books.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Business
{
	public interface IBookBusiness : IBaseBusiness<Book>
	{

	}

	public class BookBusiness : BaseBusiness<Book>, IBookBusiness
	{
		public BookBusiness(IUnitOfWork uniOfWork, IBaseRepository<Book> repository) : base(uniOfWork, repository)
		{
		}
	}
}
