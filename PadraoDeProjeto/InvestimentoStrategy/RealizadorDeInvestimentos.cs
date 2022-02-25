using InvestimentoStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoStrategy
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta, Investimento investimento)
        {
            conta.Saldo = conta.Saldo + investimento.CalculaInvestimento(conta);
            Console.WriteLine(conta.Saldo);
        }
    }
}
