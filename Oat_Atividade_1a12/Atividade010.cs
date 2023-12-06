using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade010
    {
        public void Atividade10()
        {
            Console.WriteLine("PROGRAMA INDÍCE DE MASSA CORPORAL EM ADULTOS");
            Console.WriteLine("Informe sua altura em centímetros");
            double altura = double.Parse(Console.ReadLine());
            altura = altura / 100;
            Console.WriteLine("Informe seu peso ");
            double peso = double.Parse(Console.ReadLine());

            double resultado =  peso / Math.Pow(altura, 2);

          if (resultado < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso, acesse programa 9 para descobrir seu peso ideal");

            }
          else if (resultado >= 18.5 & resultado <= 25 )
            {
                Console.WriteLine("Você está dentro do peso normal");
            }
          else if (resultado > 25 & resultado <= 30)
            {
                Console.WriteLine("Você está acima do peso, acesse programa 9 para descobrir seu peso ideal");

            }
          else
            {
                Console.WriteLine("Você está obeso(a), acesse programa 9 para descobrir seu peso ideal");
            }
          Console.ReadKey();
            
        }
    }
}
