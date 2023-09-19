using System;
using System.Collections.Generic;
class Product

{
    public int ProductID { get; set; }

    public string ProductName { get; set; }

    public double Price { get; set; }
    public Product(int productId, string productName, double price)

    {

        ProductID = productId;

        ProductName = productName;

        Price = price;

    }

}
class Program

{

    static void Main()

    {

        List<Product> productList = new List<Product>();
        for (int i = 1; i <= 10; i++)
        {

            Console.Write($"Enter the product {i} id: ");

            int productId = Convert.ToInt32(Console.ReadLine());



            Console.Write($"Enter the product {i} name: ");

            string productName = Console.ReadLine();



            Console.Write($"Enter Product {i} price: ");

            double price = Convert.ToDouble(Console.ReadLine());



            productList.Add(new Product(productId, productName, price));

        }
        productList.Sort((yourproduct,myproduct) => yourproduct.Price.CompareTo(myproduct.Price));
        Console.WriteLine("sort the products");
         foreach (var product in productList)
        {

         Console.WriteLine($"Product ID: {product.ProductID}, Product Name: {product.ProductName}, Price: {product.Price:C}");

        }

    }

}

