using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oat_Atividade_1a12
{
    internal class Atividade011
    {
        public void Atividade11()
        {
            Console.WriteLine("PROGRAMA FORMA DE PAGAMENTO E DESCONTO");

            Console.WriteLine("Informe o valor da compra");
            double compra = double.Parse(Console.ReadLine());
            double opc1 = (compra * 90) / 100;
            double opc2 = (compra * 85) / 100;
            double opc3 = compra;
            double opc4 = (compra * 110) / 100;
            Console.WriteLine("Escolha a forma de pagamento:\n" +
                $"1- Á vista em dinheiro ou cheque com 10% de desconto, total de {opc1}\n" +
                $"2- Á vista no cartão de crédito com 15% de desconto, total de {opc2}\n" +
                $"3- duas vezes, preço normal de etiqueta sem juros, total de {opc3}\n" +
                $"4- três vezes, preço normal de etiqueta mais juros de 10%, total de {opc4}");
            int opcao = int.Parse(Console.ReadLine());
            while(opcao <1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida, escolha novamente");
                opcao = int.Parse(Console.ReadLine());
            }
            
            if (opcao == 1)
            {

                Console.WriteLine($"Você pagará a vista no dinheiro ou cheque o total de {opc1}");
            }
            else if (opcao == 2) 
            {
                Console.WriteLine($"Você pagará a vista no cartão de crédito o total de {opc2}");
            }
            else if (opcao == 3)
            {
                double compraDiv2 = compra / 2;
                Console.WriteLine($"Você pagará em duas parcelas de {compraDiv2}, total de {opc3}");
            }
            else
            {
                double compraDiv3 = compra / 3;
                Console.WriteLine($"Você pagará em três parcelas de {compraDiv3}, total de {opc4}");
            }
            Console.ReadKey();


           
        }

        
    }
}
