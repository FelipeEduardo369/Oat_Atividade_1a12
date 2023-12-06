using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade003
    {
        public void Atividade03() {
            Console.WriteLine("PROGRAMA NÚMERO PAR ou ÍMPAR");
            Console.WriteLine("Informe um número");
            int num = int.Parse(Console.ReadLine());

            if (num %2 == 0) {
                Console.WriteLine("O número " + num + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + num + " é ímpar.");
            }
            Console.ReadKey();
}
    }
}
