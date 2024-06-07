using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class ContaBancaria {
        static void Main(string[] args) {

            User user;

            Console.Write("Entre com o numero da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (S/N) ?");
            char sn = char.Parse(Console.ReadLine());

            if (sn == 's') {
                Console.Write("Digite o valor do deposito: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                user = new User(nConta, titular, depositoInicial);
            }
            else {
                user = new User(nConta, titular);
            }
         
            Console.WriteLine();

            Console.WriteLine(user);

            Console.Write("Deseja realizar um deposito? (S/N): ");
            sn = char.Parse(Console.ReadLine());

            if(sn == 's') {
                Console.Write("Qual valor do deposito?: ");
                double deposito = double.Parse(Console.ReadLine());
                user.Deposito(deposito);
            }
            Console.WriteLine(user);

            Console.Write("Deseja realizar um Saque? (S/N): ");
            sn = char.Parse(Console.ReadLine());

            if (sn == 's') {
                Console.Write("Qual valor do saque?: ");
                double saque = double.Parse(Console.ReadLine());
                user.Saque(saque);
            }

            Console.WriteLine();
            Console.WriteLine(user);


        }
    }
}