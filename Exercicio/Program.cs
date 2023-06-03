using Exercicio;
using System.Globalization;
 class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(nome,numero,depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(nome,numero);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.Write("Entre com um valor de deposito:");
        double  deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        conta.Deposito(deposito);
        Console.WriteLine("Dados da conta atualizados");
        Console.Write(conta);
        Console.WriteLine();
        Console.Write("Entre com um valor de saque:");
        deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Saque(deposito);
        Console.WriteLine("Dados da conta atualizados");
        Console.Write(conta);



    }
}