using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        private readonly ICategoryRepository _repository;
        public CategoryManager(ICategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
