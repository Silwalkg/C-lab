using System;

public class Product
{
    private int _productId;
    private string _productName;
    private double _price;
    private int _quantityInStock;

    public Product(int productId, string productName, double price, int quantityInStock)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantityInStock = quantityInStock;
    }

    public string ProductName => _productName; // Read-only property for product name

    public double Price => _price; // Read-only property for price

    public int QuantityInStock
    {
        get => _quantityInStock;
        set => _quantityInStock = value; // Allow modifying quantity
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity in Stock: {_quantityInStock}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // (a) Create a product instance
        Product laptop = new Product(101, "Laptop", 800, 10);

        // (b) Access and display product details
        Console.WriteLine("Product Details:");
        laptop.DisplayInfo();

        // (c) Attempt to modify product ID directly
        // laptop._productId = 102; // This will cause a compilation error

        Console.WriteLine("\nAttempting to modify product ID directly (outside the class) will result in a compilation error as the field is private.");
    }
}
