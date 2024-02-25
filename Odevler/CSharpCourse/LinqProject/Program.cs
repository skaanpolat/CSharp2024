﻿internal class Program
{
    private static void Main(string[] args)
    {

        List<Category> categories = new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Bilgisayar"},
            new Category {CategoryId = 2, CategoryName = "Telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product {Id=1, CategoryId = 1, ProductName = "Acer Laptop" , QuantityPerUnit = "32 GB RAM" , UnitPrice = 10000, UnitsInStock = 5 },
            new Product {Id=2, CategoryId = 1, ProductName = "Asus Laptop" , QuantityPerUnit = "16 GB RAM" , UnitPrice = 8000, UnitsInStock = 3 },
            new Product {Id=3, CategoryId = 1, ProductName = "HP Laptop" , QuantityPerUnit = "8 GB RAM" , UnitPrice = 6000, UnitsInStock = 2 },
            new Product {Id=4, CategoryId = 2, ProductName = "Samsung Telefon" , QuantityPerUnit = "4 GB RAM" , UnitPrice = 5000, UnitsInStock = 15 },
            new Product {Id=5, CategoryId = 2, ProductName = "Apple Laptop" , QuantityPerUnit = "4 GB RAM" , UnitPrice = 8000, UnitsInStock = 0 }
        };

        Console.WriteLine("Algoritmik--------------------------");
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                Console.WriteLine(product.ProductName);
            }
        }


        Console.WriteLine("Linq--------------------------");

        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }


        GetProducts(products);
        foreach (Product product in GetLinqProducts(products))
        {
            Console.WriteLine(product.ProductName);
        }

    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }

    static List<Product> GetLinqProducts(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
    }


}



class Product
{
    public int Id { get; set; }
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