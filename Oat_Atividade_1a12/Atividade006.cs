using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade006
    {
        public void Atividade06()
        {

            Console.WriteLine("PROGRAMA TRUE OU FALSE");
            Console.WriteLine("Informe se o valor 1 é veradeiro com true, ou falso com false");
            bool valor1 =  bool.Parse(Console.ReadLine());
            Console.WriteLine("Informe agora o valor 2 com true ou false");
            bool valor2 = bool.Parse(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambas são verdadeiras");
            }
            else
            {
                Console.WriteLine("Algum dos valores ou ambos são falsos");
            }
            Console.ReadKey();

        }
    }
}
