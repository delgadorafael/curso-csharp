using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio6Listas
{
    class Empregado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(int p_id, string p_nome, double p_salario)
        {
            ID = p_id;
            Nome = p_nome;
            Salario = p_salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return  "ID: " + ID +
                    ", Nome " + Nome +
                    ", Salário: R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
