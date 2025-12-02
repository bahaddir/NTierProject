using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class OrderDetailManager : BaseManager<OrderDetail>, IOrderDetailManager
    {
        private readonly IOrderDetailRepository _repository;
        public OrderDetailManager(IOrderDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
    */

    public class OrderDetailManager : BaseManager<OrderDetailDto, OrderDetail>, IOrderDetailManager
    {
        private readonly IOrderDetailRepository _repository;
        private readonly IMapper _mapper;

        public OrderDetailManager(IOrderDetailRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
