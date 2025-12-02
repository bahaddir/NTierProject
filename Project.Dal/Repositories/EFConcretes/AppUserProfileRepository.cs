using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Dal.Repositories.EFConcretes
{
    public class AppUserProfileRepository : BaseRepository<AppUserProfile>, IAppUserProfileRepository
    {
        public AppUserProfileRepository(MyContext context) : base(context)
        {

        }
    }
}
