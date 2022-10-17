using ProductMicroservice.Models;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int ProductID);

        void InsertProduct(Product Product);

        void DeleteProduct(int ProductId);

        void UpdateProduct(Product Product);
        
        void Save();
    }
}

