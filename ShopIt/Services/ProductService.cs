using ShopIt.DTOs;
using ShopIt.Interfaces;
using ShopIt.Models;

namespace ShopIt.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRespository<Product> _productRepository;
        public ProductService(IGenericRespository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Create(ProductDTO productDTO)
        {
            var product = new Product
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Brand = productDTO.Brand,
                PictureURL = productDTO.PictureURL
            };

            return await _productRepository.Create(product);
        }

        public async Task<Product> Delete(Guid id)
        {
            return await _productRepository.Delete(id);
        }

        public async Task<Product> Get(Guid id)
        {
            return await _productRepository.Get(id);
        }

        public async Task<IReadOnlyList<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> Update(Product product)
        {
            return await _productRepository.Update(product);
        }
    }
}
