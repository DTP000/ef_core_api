using ef_ktr_api.Model.Product;
using ef_ktr_api.UnitOfWork;
using ef_ktr_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace EfAPI.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        [Route("Api/Products/Create")]
        public ProductReponseDto Create(ProductRequestDto input)
        {
            try
            {
                var product = new Product
                {
                    Name = input.Name,
                    Code = input.Code,
                    Price = input.Price,
                    Continue = true,
                    DateUpdated = DateTime.Now,
                    DateCreated = DateTime.Now,
                    IdCategory = input.IdCategory
                };
                var data = _unitOfWork.ProductRepository.Create(product);
                _unitOfWork.SaveChanges();
                return new ProductReponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Code = product.Code,
                    Price = product.Price,
                    Continue = product.Continue,
                    IdCategory = product.IdCategory,
                    DateCreated = product.DateCreated,
                    DateUpdated = product.DateUpdated,
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("Api/Products/Update")]
        public ProductReponseDto Update(ProductRequestUpdateDto input, int idProduct)
        {
            if (input.Id == idProduct)
            {
                try
                {
                    var product = new Product
                    {
                        Id = input.Id,
                        Name = input.Name,
                        Code = input.Code,
                        Price = input.Price,
                        Continue = input.Continue,
                        DateUpdated = DateTime.Now,
                        IdCategory = input.IdCategory
                    };
                    var data = _unitOfWork.ProductRepository.Update(product, idProduct);
                    return new ProductReponseDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Code = product.Code,
                        Price = product.Price,
                        Continue = product.Continue,
                        IdCategory = product.IdCategory,
                        DateCreated = product.DateCreated,
                        DateUpdated = product.DateUpdated,
                    };
                }
                catch (Exception e)
                {
                    return null;
                }
            } else
            {
                return null;
            }
        }

        [HttpGet]
        [Route("Api/Products/Get")]
        public ProductReponseDto GetById(int idProduct)
        {
            try
            {
                var product = _unitOfWork.ProductRepository.Get(idProduct);
                var productRs = new ProductReponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Code = product.Code,
                    Price = product.Price,
                    Continue = product.Continue,
                    IdCategory = product.IdCategory,
                    DateCreated = product.DateCreated,
                    DateUpdated = product.DateUpdated,
                };

                return productRs;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("Api/Products/GetAll")]
        public List<ProductReponseDto> GetAll()
        {
            try
            {
                var products = _unitOfWork.ProductRepository.GetAll().Select(product => new ProductReponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Code = product.Code,
                    Price = product.Price,
                    Continue = product.Continue,
                    IdCategory = product.IdCategory,
                    DateCreated = product.DateCreated,
                    DateUpdated = product.DateUpdated,
                }).ToList();
                return products;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("Api/Products/GetAllCategory")]
        public List<ProductReponseDto> GetAllCategory(int idProduct)
        {
            try
            {
                var products = _unitOfWork.ProductRepository.GetByCategory(idProduct).Select(product => new ProductReponseDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Code = product.Code,
                    Price = product.Price,
                    Continue = product.Continue,
                    IdCategory = product.IdCategory,
                    DateCreated = product.DateCreated,
                    DateUpdated = product.DateUpdated,
                }).ToList();
                return products;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
