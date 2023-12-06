using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade007
    {
        public void Atividade07()
        {
            Console.WriteLine("PROGRAMA SOMA 5 PARA PAR E 8 PARA ÍMPAR");
            Console.WriteLine("informe um número");
            int num = int.Parse(Console.ReadLine());
            int resultado = 0;

            if (num % 2 == 0)
            {
                resultado = num + 5;
                Console.WriteLine("O número " + num + " é par, somado com 5 é igual a " + resultado );

            }
            else
            {
                resultado = num + 8;
                Console.WriteLine("O número " + num + " é ímpar, somado com 8 é igual a " + resultado );

            }
            Console.ReadKey();
        }
    }

}
