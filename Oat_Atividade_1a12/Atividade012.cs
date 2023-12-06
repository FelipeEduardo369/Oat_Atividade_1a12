using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade012
    {
        public void Atividade12()
        {
            Console.WriteLine("PROGRAMA MÉDIA DE APROVEITAMENTO CONCEITO");

            Console.WriteLine("Informe seu número de identificação:");
            int identificacao = int.Parse(Console.ReadLine());

            Console.WriteLine("informe a nota 1");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a nota 2");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe a nota 3");
            double nota3 = double.Parse(Console.ReadLine());
            double media = (nota1 + nota2 + nota3) / 3;

            double mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + media) / 7;

            if (mediaAproveitamento >= 90)
            {
                Console.WriteLine($"Aluno identificação N°: {identificacao}\n" +
                    $"Notas:\n{nota1}\n" +
                    $"{nota2}\n" +
                    $"{nota3}\n" +
                    $"Com a média das avaliações igual a {media.ToString("f2")}\n" +
                    $"Teve a média de aproveitamento igual a {mediaAproveitamento.ToString("f2")}, tendo assim o conceito A.\n" +
                    "                        APROVADO");

            }
            else if(mediaAproveitamento>=75 & mediaAproveitamento<90)
            {
                Console.WriteLine($"Aluno identificação N°: {identificacao}\n" +
                  $"Notas:\n{nota1}\n" +
                  $"{nota2}\n" +
                  $"{nota3}\n" +
                  $"Com a média das avaliações igual a {media.ToString("f2")}\n" +
                  $"Teve a média de aproveitamento igual a {mediaAproveitamento.ToString("f2")}, tendo assim o conceito B.\n" +
                  "                        APROVADO");
            }
            else if (mediaAproveitamento>=60 &  mediaAproveitamento< 75)
            {
                Console.WriteLine($"Aluno identificação N°: {identificacao}\n" +
                   $"Notas:\n{nota1}\n" +
                   $"{nota2}\n" +
                   $"{nota3}\n" +
                   $"Com a média das avaliações igual a {media.ToString("f2")}" +
                   $"Teve a média de aproveitamento igual a {mediaAproveitamento.ToString("f2")}, tendo assim o conceito C.\n" +
                   "                        APROVADO");
            }
            else if (mediaAproveitamento>= 40 & mediaAproveitamento < 60)
            {
                Console.WriteLine($"Aluno identificação N°: {identificacao}\n" +
                   $"Notas:\n{nota1}\n" +
                   $"{nota2}\n" +
                   $"{nota3}\n" +
                   $"Com a média das avaliações igual a {media.ToString("f2")}\n" +
                   $"Teve a média de aproveitamento igual a {mediaAproveitamento.ToString("f2")} tendo assim o conceito D.\n" +
                   "                        REPROVADO");
            }else
            {
                Console.WriteLine($"Aluno identificação N°: {identificacao}\n" +
                   $"Notas:\n{nota1}\n" +
                   $"{nota2}\n" +
                   $"{nota3}\n" +
                   $"Com a média das avaliações igual a {media.ToString("f2")}\n" +
                   $"Teve a média de aproveitamento igual a {mediaAproveitamento.ToString("f2")}, tendo assim o conceito E.\n" +
                   "                        REPROVADO");
            }
            Console.ReadLine();

        }
    }
}
