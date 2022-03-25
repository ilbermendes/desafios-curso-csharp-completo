﻿using Desafio.Entities;
using Desafio.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data:");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Account account = new Account(number, holder, initialBalance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    account.Withdraw(amountWithdraw);

    Console.Write($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}

