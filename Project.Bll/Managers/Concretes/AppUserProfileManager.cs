using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class AppUserProfileManager : BaseManager<AppUserProfile>, IAppUserProfileManager
    {
        private readonly IAppUserProfileRepository _repository;
        public AppUserProfileManager(IAppUserProfileRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
    */
    public class AppUserProfileManager : BaseManager<AppUserProfileDto, AppUserProfile>, IAppUserProfileManager
    {
        private readonly IAppUserProfileRepository _repository;
        private readonly IMapper _mapper;

        public AppUserProfileManager(IAppUserProfileRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
