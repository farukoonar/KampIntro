using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.Name = "Masa";
            product1.UnitPrice = 120.99;
            product1.UnitsInStock = 67;

            Product product2 = new Product { Id = 2, CategoryId = 2, Name = "Kazak", UnitPrice = 70.99, UnitsInStock = 54 };
            
            //case sensitive
            //PascalCase - camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            //ref - out
        }
    }
}
