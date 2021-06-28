using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace CadFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AumentarSalario (double percentual)
        {
            Salary += Salary / 100 * percentual;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Nome: " + Name + ", Salário: " + Salary.ToString("F2", CultureInfo.InvariantCulture) + "R$" ;
        }

    }
}
