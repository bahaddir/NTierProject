using AutoMapper;
using Project.Bll.Dtos;
using Project.Bll.Managers.Abstracts;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Bll.Managers.Concretes
{
    /*
    public class CategoryManager : BaseManager<Category>, ICategoryManager
    {
        private readonly ICategoryRepository _repository;
        public CategoryManager(ICategoryRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
    */

    public class CategoryManager : BaseManager<CategoryDto, Category>, ICategoryManager
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }

}
