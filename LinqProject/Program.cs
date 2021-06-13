using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            {
                new Category{ CategoryId=1, CategoryName="Bilgisayar"},
                new Category{ CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="32 GB RAM", UnitPrice=10000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="ASUS Laptop", QuantityPerUnit="16 GB RAM", UnitPrice=8000, UnitsInStock=4},
                new Product{ProductId=3, CategoryId=1, ProductName="ACER Laptop", QuantityPerUnit="8 GB RAM", UnitPrice=12000, UnitsInStock=15},
                new Product{ProductId=4, CategoryId=2, ProductName="IPhone 6", QuantityPerUnit="2 GB RAM", UnitPrice=4000, UnitsInStock=0},
                new Product{ProductId=5, CategoryId=2, ProductName="SAMSUNG S10", QuantityPerUnit="4 GB RAM", UnitPrice=3000, UnitsInStock=11}
            };
            //WhereTest(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);

            JoinTest(categories, products);

        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitePrice = p.UnitPrice };
            foreach (var item in result)
            {
                Console.WriteLine("{0} -- {1} -- {2}", item.ProductName, item.CategoryName, item.UnitePrice);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single Line Query
            // Senaryolar Arttırılabilir.
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            //FindAll Koşula uyan tüm nesneleri getirir
            //Where ile aynı mantıkta çalışır.
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        private static void FindTest(List<Product> products)
        {
            //Find (Lambda) koşula uygun nesneye getirir. Nesneye ait tüm bilgilere erişebilirsin.
            // Genellikle detay bilgileri için kullanılır.
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.UnitPrice);
        }

        private static void AnyTest(List<Product> products)
        {
            // Any Liste içerisinde bu eleman var mı yok mu kontrolü.
            var result = products.Any(p => p.ProductName == "HP LaptoP");
            Console.WriteLine(result);
        }

        private static void WhereTest(List<Product> products)
        {
            // Where Liste içerisindeki koşullarımıza uygun elemanları getirir.
            var result = products.Where(p => p.UnitPrice > 4000 && p.UnitsInStock > 4);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        class ProductDto
        {
            public int ProductId { get; set; }

            public string CategoryName { get; set; }

            public string ProductName { get; set; }

            public decimal UnitePrice { get; set; }
        }

        class Product
        {
            public int ProductId { get; set; }

            public int CategoryId { get; set; }

            public string ProductName { get; set; }

            public string QuantityPerUnit { get; set; }

            public decimal UnitPrice { get; set; }

            public int UnitsInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }

            public string CategoryName { get; set; }
        }

    }
}
