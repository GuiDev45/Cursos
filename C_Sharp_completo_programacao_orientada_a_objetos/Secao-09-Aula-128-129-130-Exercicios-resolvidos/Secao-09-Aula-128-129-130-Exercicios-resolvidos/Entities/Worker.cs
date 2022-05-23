using System;
using System.Collections.Generic;
using System.Text;
using Secao_09_Aula_128_129_130_Exercicios_resolvidos.Entities.Enums;

namespace Secao_09_Aula_128_129_130_Exercicios_resolvidos.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//new, instânciar para que a lista não seja nula.

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)//List nunca entra em construtor.
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)//Forma correta de adicionar em lista.
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)//Forma correta de remover em lista.
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)//Método para resolver o problema dos contratos.
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
