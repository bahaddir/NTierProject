using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class ProductManager : BaseManager<Product>, IProductManager
    {
        private readonly IProductRepository _repository;
        public ProductManager(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
