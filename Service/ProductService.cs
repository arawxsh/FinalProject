using Model.DomainModels;
using Model.ServiceModels;
using Service.Dtos;

namespace Service
{
    public class ProductService
    {
            private readonly ProductServiceModel _productServiceModel;

            public ProductService()
            {
                _productServiceModel = new ProductServiceModel();
            }

            public void Post(PostProductDto postProductDtoDto)
            {
                var product = new Product()
                {
                    
                    Title = postProductDtoDto.Title,
                    UnitPrice = postProductDtoDto.UnitPrice,
                };
                _productServiceModel.Post(product);
            }

            public List<Product> GetAll()
            {
                var products = _productServiceModel.SelectAll();
                var getProductDtos = new List<GetProductDto>();
                foreach (var item in products)
                {
                    var gpd = new GetProductDto()
                    {
                        Code = item.Code,
                        Title = item.Title,
                        UnitPrice = item.UnitPrice
                    };
                    getProductDtos.Add(gpd);
                }

                return products;
            }

            public void Edit(EditProductDto editProductDtoDto)
            {
                var product = new Product()
                {
                    Code = editProductDtoDto.Code,
                    Title = editProductDtoDto.Title,
                    UnitPrice = editProductDtoDto.UnitPrice
                };
                _productServiceModel.Edit(product);
            }

            public void Delete(DeleteProductDto DeleteProductDto)
            {
                var product = new Product()
                {
                    Code = DeleteProductDto.Code
                };
                _productServiceModel.Delete(product);
            }
    }
    
}
