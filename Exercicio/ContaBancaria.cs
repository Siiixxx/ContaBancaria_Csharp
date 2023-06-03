using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio
{
    public class ContaBancaria
    {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Valor { get; private set; }

        public ContaBancaria(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;            
        }

        public ContaBancaria( string nome, int numero,double valor) : this(nome,numero)
        {
            Valor = valor;
        }

        public void Deposito(double quantia)
        {
            Valor = Valor + quantia;
        }

        public void Saque(double quantia)
        {
            Valor -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + " Titular " + Nome + " Saldo $" + Valor.ToString("F2",CultureInfo.InvariantCulture);          
        }


    }
}
