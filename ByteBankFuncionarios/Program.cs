using System;


    


namespace ByteBankFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();
            
            Console.ReadLine();

       


        }

        public static void UsarSistema()
        {

            SistemaInterno sistemaIntero = new SistemaInterno();
            Diretor roberta = new Diretor("567.423.678-78");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaIntero.Logar(roberta, "123");
            sistemaIntero.Logar(roberta, "abc");

            GerenteDeConta camila = new GerenteDeConta("326.985.628-67");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            
            sistemaIntero.Logar(roberta, "123");
            sistemaIntero.Logar(camila, "abc");

        }
        public static void CalcularBonificacao()
        {
            GerenciadorDeBonificacoes gerenciadorDeBonificacoes = new GerenciadorDeBonificacoes();

            Designer pedro = new Designer(4000, "768.879.098-09");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("567.423.678-78");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("754.368.135-65");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-67");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.765.578-89");
            guilherme.Nome = "Guilherme";

            gerenciadorDeBonificacoes.Registrar(guilherme);
            gerenciadorDeBonificacoes.Registrar(pedro);
            gerenciadorDeBonificacoes.Registrar(roberta);
            gerenciadorDeBonificacoes.Registrar(igor);
            gerenciadorDeBonificacoes.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorDeBonificacoes.GetTotalBonificacao());






        }

    }
}
