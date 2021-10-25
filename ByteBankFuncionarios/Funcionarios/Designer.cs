using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public  class Designer : Funcionario
    {
        public Designer( double salario, string cpf) : base(3000, cpf)
        {

        }

        public override void AumentarSalarios()
        {
            Salario *= 1.11;
        }
        public override double GetBonificacao()
        {
            return Salario + 0.17;
        }
    }
}
