using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Engenheira";
            //gabriela.cpf = "444.444.444-44";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "8888888899";
            conta.titular.profissao = "Advogada";


            //conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 65345;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine(); 

        }
    }
}
