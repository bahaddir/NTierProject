using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class AppUserManager : BaseManager<AppUser>,IAppUserManager
    {
        private readonly IAppUserRepository _repository;
        public AppUserManager(IAppUserRepository repository) :base(repository) 
        {
            _repository = repository;
        }
    }

}
