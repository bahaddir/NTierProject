using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Dal.Repositories.EFConcretes
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(MyContext context) : base(context)
        {

        }
    }











}
