using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3WhilePosto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
                um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
                4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
                que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
                mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
                exemplo.
             */
            int alcool = 0, gasolina = 0, diesel = 0, combustivel = 0;

            Console.WriteLine("Opciones");
            Console.WriteLine("1 - Álcool | 2 - Gasolina | 3 - Diesel | 4 - Encerrar");
            Console.WriteLine();
            Console.WriteLine("Informe o combustível escolhido; ");
            combustivel = int.Parse(Console.ReadLine());

            while(combustivel != 4)
            {
                if (combustivel < 1 || combustivel > 4)
                    Console.WriteLine("Por favor, informe um código válido!");
                else if (combustivel == 1)
                    alcool++;
                else if (combustivel == 2)
                    gasolina++;
                else
                    diesel++;

                Console.WriteLine();
                Console.WriteLine("Informe o combustível escolhido; ");
                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool - " + Convert.ToString(alcool));
            Console.WriteLine("Gasolina - " + Convert.ToString(gasolina));
            Console.WriteLine("Diesel - " + Convert.ToString(diesel));
            Console.ReadLine();
        }
    }
}
