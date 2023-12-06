using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade008
    {
        public void Atividade08()
        {
            Console.WriteLine("PROGRAMA NÚMEROS EM ORDEM DECRESCENTE");

            int[] numeros = new int[3];
            while (numeros[0] == numeros[1] || numeros[0] == numeros[2] || numeros[2] == numeros[1]) { 
            Console.WriteLine("Os números devem ser diferentes um dos outros");
            Console.WriteLine("digite o primeiro número:");
            numeros[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número:");
            numeros[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro número:");
            numeros[2] = int.Parse(Console.ReadLine());

        }

            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("Os números em ordem decrescente são: ");
            foreach (int i in numeros)
            {
               
               Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
            



