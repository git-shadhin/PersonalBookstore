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
    public class ContributorService : IContributorService
    {
        private readonly IContributorRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ContributorService(IContributorRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IQueryable<ContributorDTO> GetAll()
        {
            var contributors = _repository.GetAll();
            var dtoContributors = new List<ContributorDTO>();
            Mapper.CreateMap<Contributor, ContributorDTO>();
            ContributorDTO dtoObj = null;
            foreach (var contributor in contributors)
            {
                dtoObj = Mapper.Map<Contributor, ContributorDTO>(contributor);
                dtoContributors.Add(dtoObj);
            }
            return dtoContributors.AsQueryable();
        }

        public ContributorDTO Find(int id)
        {
            var contributor = _repository.GetById(id);
            if(contributor != null)
            {
                return Mapper.Map<Contributor, ContributorDTO>(contributor);
            }
            return null;
        }

        public void InsertOrUpdate(ContributorDTO contributor)
        {
            if (contributor != null)
            {
                Contributor b = Mapper.Map<ContributorDTO, Contributor>(contributor);
                if (contributor.ContributorID == default(int))
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
            var contributor = _repository.GetById(id);
            if (contributor != null)
            {
                _repository.Delete(contributor);
            }            
            Save();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
