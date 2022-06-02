﻿using EFCoreCRUD.Entities;

namespace EFCoreCRUD.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product CreateProduct(Product product);
        Product UpdateProduct(Product product);
        void DeleteProduct(int id);

    }
}
