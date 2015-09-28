using PersonalBookstore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Service.Contracts
{
    public interface IContributorService
    {
        IQueryable<ContributorDTO> GetAll();
        ContributorDTO Find(int id);
        void InsertOrUpdate(ContributorDTO contributor);
        void Delete(int id);
    }
}
