using PersonalBookstore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBookstore.Service.Contracts
{
    public interface IBookService
    {
        IQueryable<BookDTO> GetAll();
        BookDTO Find(int id);
        void InsertOrUpdate(BookDTO book);
        void Delete(int id);
    }
}
