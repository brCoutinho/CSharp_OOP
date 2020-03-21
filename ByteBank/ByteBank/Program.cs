using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atalho: 
            //  *Quando a diretiva não está nos using do projeto >>
            //      >>Cursor em cima da palavra > CTRL + . > Verificar as opções > Enter

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


            Funcionario thiago = new Funcionario();

            thiago.Nome = "Thiago";
            thiago.CPF = "444.444.448-89";
            thiago.Salario = 3000;

            gerenciador.Registrar(thiago);

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.CPF = "333333333";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificação: "+ gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
