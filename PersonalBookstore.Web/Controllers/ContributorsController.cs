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
    public class ContributorsController : ApiController
    {
        IContributorService _service;
        IUnitOfWork _uow;

        public ContributorsController(IContributorService service, IUnitOfWork uow)
        {
            _service = service;
            _uow = uow;
        }
        public IQueryable<ContributorDTO> Get()
        {
            return _service.GetAll();
        }
    }
}
