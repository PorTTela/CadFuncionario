using System;
using System.Collections.Generic;
using System.Globalization;

namespace CadFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Quantos funcionários você deseja registrar? ");
            int numfuncionario = int.Parse(Console.ReadLine());

            List<Funcionario> listFunc = new List<Funcionario>();

            for (int i = 0; i < numfuncionario; i++)
            {
                Console.WriteLine("Funcionário " + i + ": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());
                listFunc.Add(new Funcionario(id, name, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o código do funcionário que deseja aumentar o salário: ");
            int codigoAumento = int.Parse(Console.ReadLine());

            Funcionario funcId = listFunc.Find(x => x.Id == codigoAumento);
            if (funcId!= null)
            {
                Console.Write("Deseja aumentar o salário em quantos porcentos? ");
                double porcAumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                funcId.AumentarSalario(porcAumento);
            }
            else
            {
                Console.WriteLine("O Código não existe!");
            }
            Console.WriteLine();


            Console.WriteLine("Os funcionários cadastrados são:");
            foreach (Funcionario obj in listFunc)
            {
                Console.WriteLine(obj);


            }
        }
    }
}
