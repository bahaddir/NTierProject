using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Dal.Repositories.EFConcretes
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {

        public OrderDetailRepository(MyContext context) : base(context)
        {

        }
    }









}
