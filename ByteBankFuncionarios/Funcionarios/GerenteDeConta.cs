using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {

    

        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }

        public override void AumentarSalarios()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario + 0.25;
        }
    }
}
