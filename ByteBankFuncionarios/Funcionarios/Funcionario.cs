using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }
    
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        


        public Funcionario( double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário!");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;


        }

        public abstract void AumentarSalarios();
        public abstract double GetBonificacao();

        

        public static int TotalDefuncionarios { get; private set; }
        public Funcionario(string cpf)
        {
            TotalDefuncionarios++;
            CPF = cpf;
        }
        
    }
}
