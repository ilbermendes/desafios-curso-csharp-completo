using Desafio2.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> listOfTaxPayers = new List<TaxPayer>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer number {i}");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listOfTaxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        listOfTaxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID");

double sum = 0;

foreach (TaxPayer tp in listOfTaxPayers)
{
    sum += tp.Tax();
    Console.WriteLine($"{tp.Name}: ${tp.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
}
Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
