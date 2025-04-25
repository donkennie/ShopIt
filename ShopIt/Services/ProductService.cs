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

        public async Task<Product> Create(Product product)
        {
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
