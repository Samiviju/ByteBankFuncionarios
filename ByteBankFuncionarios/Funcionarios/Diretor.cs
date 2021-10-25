using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    class  Diretor : FuncionarioAutenticavel
    {
     
      

         public Diretor(string cpf) : base(5000 ,cpf)
        {
            
            Console.WriteLine("Criando um diretor!");
        }

        public override void AumentarSalarios()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {

            return Salario + 0.5;
        }
    }
}
