using PersonalBookstore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Service.Contracts
{
    public interface IPublisherService
    {
        IQueryable<PublisherDTO> GetAll();
        PublisherDTO Find(int id);
        void InsertOrUpdate(PublisherDTO publisher);
        void Delete(int id);
    }
}
