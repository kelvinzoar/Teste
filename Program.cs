using System;
using System.Globalization;
using Questao1.Models;
using Questao1.Services;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            IContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            ContaService contaService = new ContaService(conta);

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaService.Depositar(quantia);

            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaService.Sacar(quantia);
        }
    }
}