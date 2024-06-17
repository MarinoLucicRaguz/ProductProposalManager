using ProductProposalManager.Models;
using ProductProposalManager.Repositories.Interface;

namespace ProductProposalManager.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, ProductName = "Rukavice koje griju"},
                new Product { Id = 2, ProductName = "Udobne papuče" },
                new Product { Id = 3, ProductName = "Projektor kao TV"},
                new Product { Id = 4, ProductName = "Pametna ogrlica za ljubimce"},
                new Product { Id = 5, ProductName = "VR Naocale"},
                new Product { Id = 6, ProductName = "Dron na plin"},
                new Product { Id = 7, ProductName = "Pametni aparat za kavu"},
            };
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            return Task.FromResult(_products.AsEnumerable());
        }

        public Task<Product> GetProductById(int productId)
        {
            return Task.FromResult(_products.FirstOrDefault(p => p.Id == productId));
        }
    
    }
}
