using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3WhileCoordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
                cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
                menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
                + + primero
                - + segundo
                - - terceiro
                + - quarto
             */

            Console.Write("Informe a coordenada X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Informe a coordenada Y: ");
            int y = int.Parse(Console.ReadLine());

            while(x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primeiro quadrante.");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo quadrante.");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Terceiro quadrante.");
                else
                    Console.WriteLine("Quarto quadrante.");

                Console.WriteLine();
                Console.Write("Informe a coordenada X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Informe a coordenada Y: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
