using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios
{
    public class ParceiroComercial : Autenticavel
    {
        public string Senha { get; set; }
        public bool Auntenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
