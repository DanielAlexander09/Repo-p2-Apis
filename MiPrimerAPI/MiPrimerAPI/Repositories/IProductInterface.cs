using MiPrimerAPI.Models;

namespace MiPrimerAPI.Repositories
{
    public interface IProductInterface
    {
         Task<IEnumerable<Product>> GetAllAsync(); 
         Task<Product?> GetByIdAsync(int id); 
         Task AddAsync(Product product); 
       

    }
}
