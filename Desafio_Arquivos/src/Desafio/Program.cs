using Desafio.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            Console.Write("Enter the original file path: ");

            var sourcePath = Console.ReadLine();
            var completePath = sourcePath + @"\products.csv";
            var targetPath = @$"{sourcePath}\out\summary.csv";
            Summary summary = new Summary();

            try
            {
                using (StreamReader sr = File.OpenText(completePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] productInfo = sr.ReadLine().Split(',');
                        Product product = new Product() { Name = productInfo[0], Price = double.Parse(productInfo[1], cultureInfo) };
                        summary.Product = product;
                        summary.Quantity = int.Parse(productInfo[2], cultureInfo);

                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine($"{summary.Product.Name},{summary.GetTotal().ToString("F2", cultureInfo)}");
                        }
                    }                 
                }         
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
