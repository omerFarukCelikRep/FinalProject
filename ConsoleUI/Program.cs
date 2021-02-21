using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //O => Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (Category category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            GetAllProducts(productManager);

            GetProductByCategoryId(productManager);

            GetProductsByUnitPrice(productManager);
        }

        private static void GetProductsByUnitPrice(ProductManager productManager)
        {
            foreach (Product product in productManager.GetProductsByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductByCategoryId(ProductManager productManager)
        {
            foreach (Product product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetAllProducts(ProductManager productManager)
        {
            foreach (Product product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
