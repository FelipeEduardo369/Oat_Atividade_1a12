using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade005
    {
        public void Atividade05()

        {
            Console.WriteLine("PROGRAMA DE MÚLTIPLOS POSITIVOS E TRIPLOS NEGATIVOS");
            Console.WriteLine("Informe um número");
            int num = int.Parse(Console.ReadLine());
            int resultado = 0;

            if (num == 0)
            {
                Console.WriteLine("0 é um número neutro e não existe múltiplos");
            }
            else if (num < 0) {
                resultado = num * 3;
                Console.WriteLine("O triplo de " + num + " é igual a " + resultado);
            }
            else
            {
                resultado = num * 2;
                Console.WriteLine("O dobro de " + num + " é igual a " + resultado);
            }
            Console.ReadKey();
        }
    }
}
