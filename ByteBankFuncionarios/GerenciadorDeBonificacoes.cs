using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public class GerenciadorDeBonificacoes
    {

        
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionaro)
        {
            _totalBonificacao += funcionaro.GetBonificacao();
        }


        
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
