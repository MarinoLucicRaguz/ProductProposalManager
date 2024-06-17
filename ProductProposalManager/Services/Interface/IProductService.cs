using ProductProposalManager.Models;

namespace ProductProposalManager.Services.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int productId);
    }
}
