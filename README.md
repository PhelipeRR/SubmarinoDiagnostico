# Submarino Diagnóstico

Este projeto implementa um sistema de diagnóstico para submarinos utilizando análise de dados binários.

## Tecnologias

- **.NET**: Framework principal para desenvolvimento da aplicação
- **C#**: Linguagem de programação utilizada
- **xUnit**: Framework de testes unitários para garantir a qualidade do código

## Algoritmos

### Lógica de Iteração por Colunas

O algoritmo principal implementa uma estratégia de análise bit a bit dos dados de diagnóstico:

1. **Iteração por Colunas**: O sistema percorre cada posição de bit (coluna) nos dados binários
2. **Contagem de Bits**: Para cada coluna, conta a frequência de bits '0' e '1'
3. **Identificação de Padrões**:
   - **Bits Mais Comuns**: Identifica o bit que aparece com maior frequência em cada posição
   - **Bits Menos Comuns**: Identifica o bit que aparece com menor frequência em cada posição
4. **Construção do Resultado**: Combina os bits identificados para formar os valores de diagnóstico finais

Esta abordagem permite uma análise eficiente e precisa dos padrões binários presentes nos dados do submarino.

## Padrões de Projeto

### Princípio da Responsabilidade Única (SRP)

O projeto segue o **Single Responsibility Principle** através da separação clara de responsabilidades:

- **Classe `CalculadoraDiagnostico`**: 
  - Responsabilidade única: realizar todos os cálculos relacionados ao diagnóstico
  - Encapsula a lógica complexa de análise de bits
  - Mantém os algoritmos organizados e testáveis

- **Classe `Program`**:
  - Responsabilidade única: orquestrar a execução da aplicação
  - Mantém-se limpa e focada apenas no fluxo principal
  - Facilita a manutenção e legibilidade do código

Esta separação garante que cada classe tenha uma razão específica para mudança, tornando o código mais modular, testável e fácil de manter.

## Estrutura do Projeto

```
SubmarinoDiagnostico/
├── App/
│   ├── CalculadoraDiagnostico.cs  # Lógica de cálculo
│   ├── Program.cs                 # Ponto de entrada
│   └── App.csproj                # Configuração do projeto
├── Testes/
│   ├── UnitTest1.cs              # Testes unitários
│   └── Testes.csproj             # Configuração dos testes
└── SubmarinoDiagnostico.sln      # Solução do projeto
```

## Como Executar

1. Clone o repositório
2. Navegue até a pasta do projeto
3. Execute: `dotnet run --project App`

## Como Testar

1. Execute: `dotnet test`
2. Os testes verificarão a corretude dos algoritmos implementados