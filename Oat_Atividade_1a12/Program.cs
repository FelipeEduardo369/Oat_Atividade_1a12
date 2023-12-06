using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
            {
                 int verificador_2 = 1;
                
                 while (verificador_2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Informe a atividade desejada *de 1 a 12*");
                    int verificador = int.Parse(Console.ReadLine());
                    while (verificador < 1 || verificador > 12)
                    {
                        Console.WriteLine("fora do intervalo, digite um número válido");
                        verificador = int.Parse(Console.ReadLine());

                    }
                    switch (verificador)
                    {
                        case 1:
                            {
                                Atividade001 Atividade01 = new Atividade001();
                                Atividade01.Atividade01();
                                break;
                            }
                        case 2:
                            {   
                                Atividade002 Atividade02 = new Atividade002();
                                Atividade02.Atividade02();
                                break;

                            }
                        case 3:
                            {
                                Atividade003 Atividade03 = new Atividade003();
                                Atividade03.Atividade03();
                                break;
                            }
                        case 4:
                            {
                                Atividade004 Atividade04 = new Atividade004();
                                Atividade04.Atividade04();
                                break;
                            }
                        case 5:
                            {
                                Atividade005 Atividade05 = new Atividade005();
                                Atividade05.Atividade05();
                                break;
                            }
                        case 6:
                            {
                                Atividade006 Atividade06 = new Atividade006();
                                Atividade06.Atividade06();
                                break;
                            }
                        case 7:
                            {
                                Atividade007 Atividade07 = new Atividade007();
                                Atividade07.Atividade07();
                                break;
                            }
                        case 8:
                            {
                                Atividade008 Atividade08 = new Atividade008();
                                Atividade08.Atividade08();
                                break;
                            }
                         case 9:
                            {
                                Atividade009 Atividade09 = new Atividade009();
                                Atividade09.Atividade09();
                                break;
                            }
                        case 10:
                            {
                                Atividade010 Atividade10 = new Atividade010();
                                Atividade10.Atividade10();
                                break;
                            }
                        case 11:
                            {
                                Atividade011 Atividade11 = new Atividade011();
                                Atividade11.Atividade11();
                                break;
                            }
                        case 12:
                            {
                                Atividade012 Atividade12 = new Atividade012();
                                Atividade12.Atividade12();
                                break;
                            }


                    }

                    
                    Console.WriteLine("Digite 1 para vizualizar outra atividade, qualquer outro número para sair");
                    verificador_2 = int.Parse(Console.ReadLine());


                }
            }
           

         
                
        }

    }
}



