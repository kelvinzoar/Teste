using System;
using Questao1.Models;

namespace Questao1.Services
{
	public class ContaService
	{
		private readonly IContaBancaria _conta;

		public ContaService(IContaBancaria conta)
		{
			_conta = conta;
		}

		public void Depositar(double valor)
		{
			_conta.Deposito(valor);
			Console.WriteLine("\nDados da conta atualizados:");
			Console.WriteLine(_conta);
		}

		public void Sacar(double valor)
		{
			_conta.Saque(valor);
			Console.WriteLine("\nDados da conta atualizados:");
			Console.WriteLine(_conta);
		}
	}
}
