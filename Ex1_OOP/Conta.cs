using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_OOP
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        private string _titular;


   

        public Conta(string titular, double saldo, int numero)
        {
            Numero = numero;
            Saldo = saldo; 
            _titular = titular;
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public override string ToString()
        {
            return "Dados da conta: " +
                "\nNome: " + Titular +
                ", Agência: " + Numero +
                ", Saldo: " + Saldo + ".";
                
        }

        public double Deposit(double param) => Saldo += param;

        public double Withdraw(double param) => Saldo -= param;
    }
}
