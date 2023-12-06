using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade004
    {
        public void Atividade04()
        {
            Console.WriteLine("PROGRAMA SOMA DE NUM IGUAIS E MULT DE DIFERENTES");
            Console.WriteLine("");
            Console.WriteLine("Informe o primeiro número");
            int numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            int numB = int.Parse(Console.ReadLine());

            int numC = 0;
            
            if (numA == numB)
            {
                numC = numA + numB;
                Console.WriteLine("A soma dos números é igual a " + numC+".");
            }
            else
            {
                numC = numA * numB;
                Console.WriteLine("A multiplicação dos números é igual a " + numC + ".");
            }
            Console.ReadKey();
        }
    }
}
