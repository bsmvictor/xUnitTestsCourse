using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]    public void DeveSomar5Com10ERetornar15()
    {
        //arrange -> montagem do cenario
        int num1 = 5;
        int num2 = 10;

        //act -> execução da ação
        int resultado = _calc.Somar(num1, num2);

        //assert -> validação do resultado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar5Com10ERetornar20()
    {
        //arrange -> montagem do cenario
        int num1 = 10;
        int num2 = 10;

        //act -> execução da ação
        int resultado = _calc.Somar(num1, num2);

        //assert -> validação do resultado
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        int numero = 4;

        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornaVerdadeiro(int numero)
    {
        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }
    
    [Theory]
    [InlineData(new int [] { 1, 3, 5, 7, 9 })]
    public void DeveVerificarSeOsNumerosSaoImparesERetornaFalso(int[] numeros)
    {
        // .All: Verifica se todos os itens na coleção são aprovados quando executados
        // Parametros (o array de valores, ação a ser executada)
        Assert.All(numeros, num => Assert.False(_calc.EhPar(num)));
    }
    
}