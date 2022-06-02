using EFCoreCRUD.DataAccess.Abstract;
using EFCoreCRUD.Entities;

namespace EFCoreCRUD.DataAccess.Concrete
{
    public class ProductSqlRepository : IProductRepository
    {
        private readonly DataBaseContext _pCtx;

        public ProductSqlRepository()
        {
            _pCtx = new DataBaseContext(); //pDbContext;
        }

        public Product CreateProduct(Product product)
        {            
            _pCtx.Products.Add(product);
            _pCtx.SaveChanges();
            return product;
        }
        public List<Product> GetAllProducts()
        {
            return _pCtx.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _pCtx.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product UpdateProduct(Product product)
        {
            _pCtx.Products.Update(product);
            _pCtx.SaveChanges();
            return product;

        }
        public void DeleteProduct(int id)
        {
            var deletedProduct = GetProductById(id);
            _pCtx.Products.Remove(deletedProduct);
            _pCtx.SaveChanges();
        }
    }
}
