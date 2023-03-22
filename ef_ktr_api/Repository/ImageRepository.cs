using ef_ktr_api.Data;
using ef_ktr_api.Repository.Interface;

namespace ef_ktr_api.Repository
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private readonly AppDb _context;

        public ImageRepository(AppDb context) : base(context)
        {
            _context = context;
        }
    }
}
