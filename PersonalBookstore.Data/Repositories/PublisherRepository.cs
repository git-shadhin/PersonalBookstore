using PersonalBookstore.Data.Infrastructure;
using PersonalBookstore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Data.Repositories
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }

    }
    public interface IPublisherRepository : IRepository<Publisher>
    {

    }
}
