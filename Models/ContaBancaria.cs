using System;
using System.Globalization;
using Questao1.Models;

namespace Questao1.Models
{
    public class ContaBancaria : IContaBancaria
    {
        public int Numero { get; }
        public string Titular { get; private set; }
        private double _saldo;

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            _saldo = 0.0;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

        public void AlterarTitular(string novoTitular)
        {
            Titular = novoTitular;
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public void Saque(double valor)
        {
            const double TAXA_SAQUE = 3.50;
            _saldo -= (valor + TAXA_SAQUE);
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
