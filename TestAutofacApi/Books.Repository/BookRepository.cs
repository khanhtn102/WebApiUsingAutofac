﻿using Books.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Repository
{
	public interface IBookRepository : IBaseRepository<Book>
	{

	}

	public class BookRepository : BaseRepository<Book>, IBookRepository
	{
		public BookRepository(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
