using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoThiago = new ContaCorrente();

            contaDoThiago.titular = "Thiago";
            contaDoThiago.agencia = 1234;
            contaDoThiago.numero = 123456;
            contaDoThiago.saldo = 100;

            Console.WriteLine(contaDoThiago.titular);
            Console.WriteLine(contaDoThiago.agencia);
            Console.WriteLine(contaDoThiago.numero);
            Console.WriteLine(contaDoThiago.saldo);

            Console.ReadLine();
        }
    }
}
