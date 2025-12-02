using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class AppUserProfileManager : BaseManager<AppUserProfile>, IAppUserProfileManager
    {
        private readonly IAppUserProfileRepository _repository;
        public AppUserProfileManager(IAppUserProfileRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
