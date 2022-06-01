using System;

namespace Secao_17_Aula_242_Exercicio_fixacao.Entities
{
    internal class Employee
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public Double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}