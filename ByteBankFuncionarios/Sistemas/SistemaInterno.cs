using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBankFuncionarios


{
    public class SistemaInterno
    {
        public  bool Logar(Funcionario funcionario, string senha)
    {
            bool usarioAutenticado = funcionario.Autenticar(senha);
            if (usarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
    }
    }
}
