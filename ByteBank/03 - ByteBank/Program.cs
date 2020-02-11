using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste para verificação de Referências de Classes
            ContaCorrente contaDoJoao = new ContaCorrente();
            contaDoJoao.titular = "João";
            contaDoJoao.agencia = 863;
            contaDoJoao.numero = 863452;

            ContaCorrente contaDoJoaoPedro = new ContaCorrente();
            contaDoJoaoPedro.titular = "João";
            contaDoJoaoPedro.agencia = 863;
            contaDoJoaoPedro.numero = 863452;

            Console.WriteLine(contaDoJoao == contaDoJoaoPedro);

            Console.ReadLine();

        }
    }
}
