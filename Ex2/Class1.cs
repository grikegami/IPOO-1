using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public void SetTitular(string titular)
        {
            Titular = titular;
        }

        public void SetSaldo(double saldo)
        {
            Saldo = saldo;
        }

        public string GetTitular()
        {
            return Titular;
        }
        public double GetSaldo()
        {
            return Saldo;
        }

        public void DepositarValor(double valor, double saldo)
        {
            saldo = GetSaldo();
            Saldo = saldo + valor;
        }
        public void SacarValor(double valor, double saldo)
        {
            saldo = GetSaldo();
            saldo = saldo - valor;
            Console.WriteLine($"\nValor retirado: {valor}");
        }

        public void ExibirSaldo(double saldo)
        {
            saldo = Saldo;
            Console.WriteLine("Seu saldo é de: "+saldo+"\n");
        }

        public override string ToString()
        {
            return $"\nTitular: {this.Titular}\nSaldo: {this.Saldo}";
        }
    }
}
