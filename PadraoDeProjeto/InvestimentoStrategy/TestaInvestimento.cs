using System;

namespace InvestimentoStrategy
{
    internal class TestaInvestimento
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria(100); 

            Investimento conservador = new Conservador();
            Investimento moderado = new Moderado();
            Investimento arrojado = new Arrojado();

            RealizadorDeInvestimentos realizadorDeInvestimentos = new RealizadorDeInvestimentos();

            realizadorDeInvestimentos.RealizaInvestimento(conta1,conservador);
            realizadorDeInvestimentos.RealizaInvestimento(conta1, moderado);
            realizadorDeInvestimentos.RealizaInvestimento(conta1, arrojado);

        }
    }
}
