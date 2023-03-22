using ef_ktr_api.Data;

namespace ef_ktr_api.Repository.Interface
{
    public interface IImageRepository : IRepository<Images>
    {
       string DoiFileAnhSangChuoi(IFormFile file);
       string DoiNhieuFileAnhSangChuoi(IList<IFormFile> files);
    }
}
