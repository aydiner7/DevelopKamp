using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET
            // Entity Framework : Bir ORM 'dir. : ORM = Object Relational Mapping

            //GetAll();
            GetProductsByCategoryId(3);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var item in northwindContext.Products)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void GetProductsByCategoryId(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
