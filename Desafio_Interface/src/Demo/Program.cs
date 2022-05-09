using Demo.Entities;
using Demo.Services;
using System;
using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installment: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            var paypalService = new PaypalService();

            var contract = new Contract(number, date, contractValue);
            var contractService = new ContractService(paypalService);

            contractService.PerformContract(contract, numberOfInstallments);

            Console.WriteLine("Installments:");

            foreach (var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
