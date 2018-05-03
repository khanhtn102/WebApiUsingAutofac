using Books.Business;
using Books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestAutofacApi.Controllers
{
    public class BooksController : ApiController
    {
		IBookBusiness _booksBusiness;

		public BooksController(IBookBusiness booksBusiness)
		{
			this._booksBusiness = booksBusiness;
		}

        // GET: api/Books
        public IEnumerable<Book> Get()
        {
			return _booksBusiness.GetAll();
        }

        // GET: api/Books/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
        }
    }
}
