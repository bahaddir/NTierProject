using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class ProductManager : BaseManager<Product>, IProductManager
    {
        private readonly IProductRepository _repository;
        public ProductManager(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
    */

    public class ProductManager : BaseManager<ProductDto, Product>, IProductManager
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
