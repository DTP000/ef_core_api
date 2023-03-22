using ef_ktr_api.Model.Category;
using ef_ktr_api.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace EfAPI.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("api/category/getAll")]
        public List<CategoryReponseDto> GetAll()
        {
            try
            {
                var categories = _unitOfWork.CategoryRepository.GetAll().Select( x => new CategoryReponseDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    DateCreated = x.DateCreated,
                    DateUpdated = x.DateUpdated
                }).ToList();
                return categories;
            }
            catch(Exception e)
            {
                return new List<CategoryReponseDto>();
            }
        }
    }
}
