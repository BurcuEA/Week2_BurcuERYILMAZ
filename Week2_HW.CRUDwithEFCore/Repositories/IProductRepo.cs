using Week2_HW.CRUDwithEFCore.Models;

namespace Week2_HW.CRUDwithEFCore.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product InsertProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(int id);


    }
}
