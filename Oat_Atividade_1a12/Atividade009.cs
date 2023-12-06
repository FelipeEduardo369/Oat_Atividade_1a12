using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade009
    {
        public void Atividade09()
        {
            Console.WriteLine("PROGRAMA PESO IDEAL");
            Console.WriteLine("Informe sua altura em centímetros");
            double altura = double.Parse(Console.ReadLine());
            altura = altura / 100;
            
           
            Console.WriteLine("Informe seu sexo com 1 para masculino e 2 para feminino");
            int sexo = int.Parse(Console.ReadLine());
            while (sexo != 1 & sexo != 2)
            {
                Console.WriteLine("Opção inválida, digite novamante");
                sexo = int.Parse(Console.ReadLine());

            }
            if (sexo == 1 )
            {
                double resultado = (72.7* altura) -58;
                Console.WriteLine($"Seu peso ideal é: {resultado}");
            }
            else
            {
                double resultado = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é: {resultado}");
            }

            Console.ReadKey();
        
        }
    }
}
