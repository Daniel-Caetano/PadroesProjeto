using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoStrategy
{
    public class Conservador : Investimento
    {
        public double CalculaInvestimento(ContaBancaria conta)
        {
            return 0.75 * (conta.Saldo*0.008);
        }
    }
}
'