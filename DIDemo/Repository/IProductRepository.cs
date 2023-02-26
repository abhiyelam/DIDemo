using DIDemo.Models;

namespace DIDemo.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        public Product GetProductById(int id);
        public int AddProduct(Product product);
        public int UpdateProduct(Product product);
        public int DeleteProduct(int id);

    }
}
