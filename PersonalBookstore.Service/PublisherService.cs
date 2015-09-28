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
    public class PublisherService : IPublisherService
    {
        private readonly IPublisherRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public PublisherService(IPublisherRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IQueryable<PublisherDTO> GetAll()
        {
            var publishers = _repository.GetAll();
            var dtoPublishers = new List<PublisherDTO>();
            Mapper.CreateMap<Publisher, PublisherDTO>();
            foreach (var publisher in publishers)
            {
                dtoPublishers.Add(Mapper.Map<Publisher, PublisherDTO>(publisher));
            }
            return dtoPublishers.AsQueryable();
        }

        public PublisherDTO Find(int id)
        {
            var publisher = _repository.GetById(id);
            if (publisher != null)
            {
                return Mapper.Map<Publisher, PublisherDTO>(publisher);
            }
            return null;
        }

        public void InsertOrUpdate(PublisherDTO publisher)
        {
            if (publisher != null)
            {
                Publisher b = Mapper.Map<PublisherDTO, Publisher>(publisher);
                if (publisher.PublisherID == default(int))
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
            var publisher = _repository.GetById(id);
            if (publisher != null)
            {
                _repository.Delete(publisher);
            }            
            Save();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
