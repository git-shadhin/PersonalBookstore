using PersonalBookstore.Data.Infrastructure;
using PersonalBookstore.DTO;
using PersonalBookstore.Model;
using PersonalBookstore.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PersonalBookstore.Data.Repositories;
namespace PersonalBookstore.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IBookRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IQueryable<BookDTO> GetAll()
        {
            var books = _repository.GetAll();
            var dtoBooks = new List<BookDTO>();
            Mapper.CreateMap<Book, BookDTO>();
            foreach (var book in books)
            {
                dtoBooks.Add(Mapper.Map<Book, BookDTO>(book));
            }
            return dtoBooks.AsQueryable();
        }

        public BookDTO Find(int id)
        {
            var book = _repository.GetById(id);
            if(book != null)
            {
                return Mapper.Map<Book, BookDTO>(book);
            }
            return null;
        }

        public void InsertOrUpdate(BookDTO book)
        {
            if (book != null)
            {
                Book b = Mapper.Map<BookDTO, Book>(book);
                if (book.BookID == default(int))
                {
                    // New entity
                    _repository.Add(b);
                    Save();
                }
                else
                {
                    // Existing entity
                    _repository.Update(b);
                    Save();
                }
            }
        }
        public void Delete(int id)
        {
            var book = _repository.GetById(id);
            if (book != null)
            {
                _repository.Delete(book);
            }            
            Save();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
