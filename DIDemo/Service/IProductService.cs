using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        public Product GetProductById(int id);
        public int AddProduct(Product product);
        public int UpdateProduct(Product product);
        public int DeleteProduct(int id);

    }
}
