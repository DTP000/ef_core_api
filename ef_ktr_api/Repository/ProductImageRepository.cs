using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.Repository
{
    public class ProductImageRepository : Repository<Product_Image>, IProductImageRepository
    {
        private readonly AppDb _context;

        public ProductImageRepository(AppDb context) : base(context)
        {
            _context = context;
        }
    }
}
