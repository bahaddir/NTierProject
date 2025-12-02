using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class OrderDetailManager : BaseManager<OrderDetail>, IOrderDetailManager
    {
        private readonly IOrderDetailRepository _repository;
        public OrderDetailManager(IOrderDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
