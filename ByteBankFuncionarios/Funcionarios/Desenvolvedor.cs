using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor (string cpf) : base(3000, cpf)
        {

        }

        public override void AumentarSalarios()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario + 0.1;
        }
    }
}
