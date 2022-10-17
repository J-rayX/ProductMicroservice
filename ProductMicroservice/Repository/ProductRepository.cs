
using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProductMicroservice.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Delete Product by ID
        public void DeleteProduct(int ProductId)
        {
            var product = _dbContext.Products.Find(ProductId);
            _dbContext.Products.Remove(product);
            Save();
        }


        // Get Products by ID
        public Product GetProductByID(int ProductId)
        {
            return _dbContext.Products.Find(ProductId);
        }

        // Get all Products
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        // Add Product
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        // Update Product by ID
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

        // Save
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

