using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente();

            contaDaMaria.titular = "Maria";

            Console.WriteLine(contaDaMaria.saldo);
            contaDaMaria.Sacar(50);
            Console.WriteLine(contaDaMaria.saldo);

            contaDaMaria.Depositar(500);

            Console.WriteLine(contaDaMaria.saldo);

            ContaCorrente contaDaDuda = new ContaCorrente();

            contaDaDuda.titular = "Maria Eduarda";

            contaDaMaria.Transferir(100, contaDaDuda);

            Console.WriteLine("Saldo da Conta da Maria: " + contaDaMaria.saldo);
            Console.WriteLine("Saldo da Conta da Duda: " + contaDaDuda.saldo);


            Console.ReadLine();
        }
    }
}
