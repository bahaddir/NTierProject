using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Dal.Repositories.EFConcretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(MyContext context) : base(context)
        {

        }
    }








}
