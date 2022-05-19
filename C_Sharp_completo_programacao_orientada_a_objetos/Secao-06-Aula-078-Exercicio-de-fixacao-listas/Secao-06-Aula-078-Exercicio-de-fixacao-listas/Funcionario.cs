using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_06_Aula_078_Exercicio_de_fixacao_listas
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }


        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
