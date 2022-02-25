using System;

namespace PadraoDeProjeto
{
    public class TesteDeImpostos
    {
        static void Main(String[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();
            Orcamento orcamento = new Orcamento(3000.0);
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            //calculando ICCC
            calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
