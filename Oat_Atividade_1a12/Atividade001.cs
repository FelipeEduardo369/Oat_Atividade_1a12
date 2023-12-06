using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade001
    {


        public void Atividade01()
        {
            int soma = 0;
            Console.WriteLine("PROGRAMA DE SOMA E COMPARAÇÃO");
            Console.WriteLine();
            Console.WriteLine("informe o valor A:");
            int valorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor B:");
            int valorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor C:");
            int valorC = int.Parse(Console.ReadLine());
            soma = valorA + valorB;
            

            if ( valorC > soma )
            {
                Console.WriteLine("A soma do valor A= " + valorA + " e valor B= " + valorB + " (" + soma + ") é menor que valor C= " + valorC);
            } else
            {
                Console.WriteLine("A soma do valor A= " + valorA + " e valor B= " + valorB + " (" + soma + ") é maior ou igual a valor C= " + valorC );
            }
            Console.ReadKey();
                   
                }

    }
}

