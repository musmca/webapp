using webappDB.Models;

namespace webappDB.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}