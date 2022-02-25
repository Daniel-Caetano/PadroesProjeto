using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoStrategy
{
    public class Arrojado : Investimento
    {
        public double CalculaInvestimento(ContaBancaria conta)
        {
            Random aleatorio = new Random();
            int chance = aleatorio.Next(1, 11);

            if (chance <= 2)
            {
                return 0.75 * (conta.Saldo * 0.05);
            }
            else if(chance >2 && chance <= 5)
            {
                return 0.75 * (conta.Saldo * 0.03);
            }
            else
            {
                return 0.75 * (conta.Saldo * 0.006);
            }
        }
    }
}
