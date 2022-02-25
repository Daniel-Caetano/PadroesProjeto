using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoStrategy
{
    public interface Investimento
    {
        public double CalculaInvestimento(ContaBancaria conta);
    }
}
