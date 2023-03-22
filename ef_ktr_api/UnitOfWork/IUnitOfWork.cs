using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        IImageRepository ImageRepository { get; }

        void SaveChanges();
        void CreateTransaction();
        void Commit();
        void Rollback();
    }
}
