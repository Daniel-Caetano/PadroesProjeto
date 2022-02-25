using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoStrategy
{
    public class Moderado : Investimento
    {
        public double CalculaInvestimento(ContaBancaria conta)
        {
            Random aleatorio = new Random();
            int chance = aleatorio.Next(1,3);

            if (chance == 1)
            {
                return 0.75 * (conta.Saldo * 0.025);
            }
            else
            {
                return 0.75 * (conta.Saldo * 0.007);
            }
        }
    }
}
