using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade002
    {
        public void Atividade02()
        {
            Console.WriteLine("BASE DE INFORMAÇÕES CONJUGAIS");
            Console.WriteLine();
            Console.WriteLine("Informe seu nome"); ;
            string nome = Console.ReadLine(); 

            Console.WriteLine("informe seu sexo com 1 para feminino e 2 para masculimo");
            int sexo = int.Parse(Console.ReadLine());

            while (sexo != 1 & sexo != 2 ) {
                Console.WriteLine("Opção inválida, tente novamante");
                 sexo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe seu estado civil com 1 para casada(o), 2 para solteira(o) e 3 para viúva(o)");
            int EstCivil = int.Parse(Console.ReadLine());

            while (EstCivil != 1 & EstCivil != 2 & EstCivil != 3) {
                Console.WriteLine("Opçao inválida, digite novamante");
                EstCivil = int.Parse(Console.ReadLine());

            }

            if (EstCivil == 1 & sexo == 1)
            {
                Console.WriteLine("informe o tempo de casada");
                 string tempo = Console.ReadLine();

                Console.WriteLine("Você, " + nome + ", tem " + tempo + " de casada");
            }
            else
            {
                Console.WriteLine("obrigado por utilizar o progama");
            }
            Console.ReadKey();

        }
    }
}
