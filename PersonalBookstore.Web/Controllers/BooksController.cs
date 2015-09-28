using PersonalBookstore.Data.Infrastructure;
using PersonalBookstore.DTO;
using PersonalBookstore.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PersonalBookstore.Web.Controllers
{
    public class BooksController : ApiController
    {
        IBookService _service;
        IUnitOfWork _uow;

        public BooksController(IBookService service, IUnitOfWork uow)
        {
            _service = service;
            _uow = uow;
        }
        public IQueryable<BookDTO> Get()
        {
            return _service.GetAll();
        }
    }
}
