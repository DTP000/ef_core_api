using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly AppDb _context;

        public ProductRepository(AppDb context) : base(context)
        {
            _context = context;
        }
        public List<Product> GetByCategory(int idCategory)
        {
            return _context.Products.Where(x => x.IdCategory == idCategory).ToList();
        }
    }
}
