using ProductProposalManager.Models;

namespace ProductProposalManager.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int productId);
    }
}
