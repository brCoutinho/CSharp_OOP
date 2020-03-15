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

            Funcionario thiago = new Funcionario();

            thiago.Nome = "Thiago";
            thiago.CPF = "444.444.448-89";
            thiago.Salario = 3000;

            Console.WriteLine(thiago.Nome);
            Console.WriteLine(thiago.GetBonificacao());

            Console.ReadLine();
        }
    }
}
