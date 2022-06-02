using EFCoreCRUD.Business.Abstract;
using EFCoreCRUD.DataAccess.Abstract;
using EFCoreCRUD.Entities;

namespace EFCoreCRUD.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository pRepo)
        {
            _productRepository = pRepo; //new ProductSqlRepository();
        }
       
        public Product CreateProduct(Product product)
        {
            return _productRepository.CreateProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public Product UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
             _productRepository.DeleteProduct(id);
        }
    }
}
