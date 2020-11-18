using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Account
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Account(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Account(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
                
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
