using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }
        public override void AumentarSalarios()
        {
            Salario *= 1.1;

        }
        public override double GetBonificacao()
        {
            return Salario + 0.2;
        }
    }

}
