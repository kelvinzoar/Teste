using System;
using System.Globalization;

namespace Questao1
{
    class ContaBancaria
    {
        // Propriedades privadas e imutáveis
        public int Numero { get; }
        public string Titular { get; private set; }
        private double _saldo;

        // Construtor sem depósito inicial
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            _saldo = 0.0; // Saldo inicial zero
        }

        // Construtor com depósito inicial
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial); // Já chama o método de depósito
        }

        // Método para alterar o nome do titular
        public void AlterarTitular(string novoTitular)
        {
            Titular = novoTitular;
        }

        // Método para depósito (saldo só pode ser aumentado por aqui)
        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        // Método para saque (saldo só pode ser diminuído por aqui)
        public void Saque(double valor)
        {
            const double TAXA_SAQUE = 3.50;
            _saldo -= (valor + TAXA_SAQUE);
        }

        // Método para exibir os dados da conta
        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}