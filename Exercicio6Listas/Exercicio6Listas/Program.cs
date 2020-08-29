using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado e;
            List<Empregado> empregados = new List<Empregado>();
            Console.WriteLine("Quanto empregados serão registrados?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o Salário: ");
                double salario = double.Parse(Console.ReadLine());

                e = new Empregado(id, nome, salario);
                empregados.Add(e);

            }

            Console.WriteLine("Informe o ID do usuário que receberá o aumento de salário: ");
            int idAumento = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Empregado empAumento = empregados.Find(x => x.ID == idAumento);
            empAumento.AumentarSalario(porcentagem);

            Console.WriteLine();

            Console.WriteLine("LISTA DE FUNCIONÁRIOS ATUALIZADA");
            foreach(Empregado obj in empregados)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.ReadLine();


        }
    }
}
