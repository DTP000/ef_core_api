using ef_ktr_api.Data;

namespace ef_ktr_api.Repository.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetByCategory(int categoryId);
    }
}
