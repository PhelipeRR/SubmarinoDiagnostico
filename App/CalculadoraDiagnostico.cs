using System.Text;

public class CalculadoraDiagnostico
{
    public int CalcularConsumoEnergia(List<string> relatorio)
    {
       
        if (relatorio == null || relatorio.Count == 0)
        {
            return 0;
        }

        string taxaGamaBinaria = CalcularTaxaGama(relatorio);
        string taxaEpsilonBinaria = CalcularTaxaEpsilon(relatorio);

       
        int taxaGamaDecimal = Convert.ToInt32(taxaGamaBinaria, 2);
        int taxaEpsilonDecimal = Convert.ToInt32(taxaEpsilonBinaria, 2); 
        return taxaGamaDecimal * taxaEpsilonDecimal;
    }

    private string CalcularTaxaGama(List<string> relatorio)
    {
        var taxaGama = new StringBuilder();
        int numeroDeBits = relatorio[0].Length;

        for (int i = 0; i < numeroDeBits; i++)
        {
            int contagemDeZeros = 0;
            int contagemDeUns = 0;

            foreach (var numeroBinario in relatorio)
            {
                if (numeroBinario[i] == '1')
                {
                    contagemDeUns++;
                }
                else
                {
                    contagemDeZeros++;
                }
            }
            taxaGama.Append(contagemDeUns > contagemDeZeros ? '1' : '0');
        }
        return taxaGama.ToString();
    }

    private string CalcularTaxaEpsilon(List<string> relatorio)
    {
        var taxaEpsilon = new StringBuilder();
        int numeroDeBits = relatorio[0].Length;

        for (int i = 0; i < numeroDeBits; i++)
        {
            int contagemDeZeros = 0;
            int contagemDeUns = 0;

            foreach (var numeroBinario in relatorio)
            {
                if (numeroBinario[i] == '1')
                {
                    contagemDeUns++;
                }
                else
                {
                    contagemDeZeros++;
                }
            }
            taxaEpsilon.Append(contagemDeUns < contagemDeZeros ? '1' : '0');
        }
        return taxaEpsilon.ToString();
    }
}