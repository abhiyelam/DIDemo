using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db) //injct the dependency
        { 
            this.db = db;
        }

        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            int result=db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var p = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (p != null)
            {
                db.Products.Remove(p);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            var product = db.Products.Find(id);
            return product;
        }

        public int UpdateProduct(Product product)
        {
            int result = 0;
            var p = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = product.Name;
                p.Price = product.Price;
                p.Company = product.Company;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
