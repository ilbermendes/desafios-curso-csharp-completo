﻿using Desafio1.Entities;
using System.Globalization;

List<Product> productsList = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        productsList.Add(new UsedProduct(name, price, date));
    }
    else if (ch == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        productsList.Add(new ImportedProduct(name, price, customsFee));
    }
    else
    {
        productsList.Add(new Product(name, price));
    }
}

Console.WriteLine();

Console.WriteLine("PRICE TAGS:");
foreach (Product p in productsList)
{
    Console.WriteLine(p.PriceTag());
}