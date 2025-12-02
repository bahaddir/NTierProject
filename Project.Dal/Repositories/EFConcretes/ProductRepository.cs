using Project.Dal.ContextClasses;
using Project.Dal.Repositories.Abstarcts;
using Project.Entities.Models;

namespace Project.Dal.Repositories.EFConcretes
{
    public class ProductRepository : BaseRepository <Product>, IProductRepository
    {
        public ProductRepository(MyContext context) : base(context)
        {

        }
    }
}
