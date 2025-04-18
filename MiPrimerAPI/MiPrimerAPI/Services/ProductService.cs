using MiPrimerAPI.Models;
using MiPrimerAPI.Repositories;

namespace MiPrimerAPI.Services
{
    public class ProductService
    {
        private readonly IProductInterface _repo;
        public ProductService(IProductInterface repo) => _repo = repo;
        public Task<IEnumerable<Product>> GetAllProducts() =>
        _repo.GetAllAsync();
    }
}
