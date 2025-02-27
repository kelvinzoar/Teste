using System;
using System.Globalization;

namespace Questao1.Models
{
    public interface IContaBancaria
    {
        int Numero { get; }
        string Titular { get; }
        void AlterarTitular(string novoTitular);
        void Deposito(double valor);
        void Saque(double valor);
        string ToString();
    }
}