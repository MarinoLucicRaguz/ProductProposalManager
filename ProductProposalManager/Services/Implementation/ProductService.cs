using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Interface;
using ProductProposalManager.Services.Interface;

namespace ProductProposalManager.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }

    }
}
