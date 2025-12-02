using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class OrderManager : BaseManager<Order>, IOrderManager
    {
        private readonly IOrderRepository _repository;
        public OrderManager(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
    */

    public class OrderManager : BaseManager<OrderDto, Order>, IOrderManager
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderManager(IOrderRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
