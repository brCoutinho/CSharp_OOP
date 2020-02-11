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

            Console.ReadLine();
        }
    }
}
