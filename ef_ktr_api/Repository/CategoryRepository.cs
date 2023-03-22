using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly AppDb _context;

        public CategoryRepository(AppDb context) : base(context)
        {
            _context = context;
        }
    }
}
