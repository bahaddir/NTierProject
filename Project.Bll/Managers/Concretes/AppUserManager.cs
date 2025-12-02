using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        private readonly IAppUserRepository _repository;
        public AppUserManager(IAppUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

    */
    public class AppUserManager : BaseManager<AppUserDto, AppUser>, IAppUserManager
    {
        private readonly IAppUserRepository _repository;
        private readonly IMapper _mapper;

        public AppUserManager(IAppUserRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
