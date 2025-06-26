var relatorioDiagnostico = new List<string>
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
int consumoDeEnergia = calculadora.CalcularConsumoEnergia(relatorioDiagnostico);
Console.WriteLine($"O consumo de energia do submarino é: {consumoDeEnergia}");