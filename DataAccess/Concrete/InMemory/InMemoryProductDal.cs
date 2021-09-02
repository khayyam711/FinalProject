using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
         
        public InMemoryProductDal()     // COSTRUCTOR
        {
            _products = new List<Product> {
                
                new Product{ProductId=1, CategoryID=1, ProductName="BOOK",UnitPrice=15,UnitsInStock=8},
                new Product{ProductId=2, CategoryID=2, ProductName="Camera",UnitPrice=42,UnitsInStock=3},
                new Product{ProductId=3, CategoryID=1, ProductName="Laptop",UnitPrice=488,UnitsInStock=7},
                new Product{ProductId=4, CategoryID=2, ProductName="Table",UnitPrice=13,UnitsInStock=5},
                new Product{ProductId=5, CategoryID=1, ProductName="Monitor",UnitPrice=89,UnitsInStock=2}

            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ  Language Integrated Query 
            //   "  =>  " LAMBDA 
 

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetALLByCategory(int categoryId)
        {
           return  _products.Where(p => p.CategoryID == categoryId).ToList();

        }


        //UPDATE 
        public void Update(Product product)
        {
            Product productUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryID = product.CategoryID;
            productUpdate.UnitPrice = productUpdate.UnitPrice;
            productUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
