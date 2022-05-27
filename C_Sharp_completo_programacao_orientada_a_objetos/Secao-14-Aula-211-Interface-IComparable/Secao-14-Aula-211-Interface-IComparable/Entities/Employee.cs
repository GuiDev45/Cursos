using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Secao_14_Aula_211_Interface_IComparable.Entities
{
    internal class Employee : IComparable<Employee>//Chamou a interface IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)//Esse construtor vai acomodar cada nome e salario que esta no arquivo in.txt
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Esse é o método gerado pela interface.
        //É preciso comparar um funcionario/Employee com outro, e a decisão vai do negócio,
        //é mais importante comparar pelo nome ou pelo salario ?
        public int CompareTo(Employee obj)
        {
            if (!(obj is Employee))//Se o o obj não for Employee
            {
                throw new ArgumentException("Comparing error");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);//Compara por nome, nome com outro/other nome
            //return Salary.CompareTo(other.Salary);//Compara por salario, salario com outro/other salario
        }
    }
}
