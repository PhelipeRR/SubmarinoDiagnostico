using Xunit;
using System.Collections.Generic;

public class DiagnosticoTests
{
    [Fact]
    public void CalcularConsumoEnergia_ComDadosDoExemplo_RetornaValorCorreto()
    {
        var relatorioExemplo = new List<string>
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };

        var calculadora = new CalculadoraDiagnostico();
        var resultadoEsperado = 198;

        int resultadoCalculado = calculadora.CalcularConsumoEnergia(relatorioExemplo);

        Assert.Equal(resultadoEsperado, resultadoCalculado);
    }
}