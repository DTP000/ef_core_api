using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDb _context;
        public ICategoryRepository CategoryRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IProductImageRepository ProductImageRepository { get; }
        public IImageRepository ImageRepository { get; }

        public UnitOfWork(AppDb context, IProductRepository productRepository, ICategoryRepository categoryRepository, IProductImageRepository productImageRepository, IImageRepository imageRepository)
        {
            _context = context;
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
            ProductImageRepository = productImageRepository;
            ImageRepository = imageRepository;
        }
        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
