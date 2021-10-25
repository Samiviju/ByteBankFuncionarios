namespace ByteBankFuncionarios.Sistemas
{
    public class SistemaInternoBase
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                
                
                return true;

            }
            else
            {
                
                return false;
            }
        }
    }
}