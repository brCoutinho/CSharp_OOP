using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1234,3561818);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaNathalia = new ContaCorrente(8589, 3547828);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
             

            Console.ReadLine();

        }
    }
}
