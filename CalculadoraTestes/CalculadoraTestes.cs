using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{

    private CalculadoraCodigo calculadora;

    public CalculadoraTestes()
    {
        calculadora = new CalculadoraCodigo();
    }


    // metodo para testar soma
    [Fact]
    public void TestaSomaDe12e10SeIgualA22()
    {

        // arrange: cria o teste
        int valor1 = 12;
        int valor2 = 10;

        // act: executa o teste
        int resultadoDaSoma = calculadora.Somar(valor1, valor2);

        //assert:  verifica o resultado do teste
        Assert.Equal(22, resultadoDaSoma);

    }

    // metodo para testar subtracao
    [Fact]
    public void TestaSubtracaoDe10Menos5()
    {
        // arrange
        int valor1 = 10;
        int valor2 = 5;

        // act
        int resultadoSubtracao = calculadora.Subtrair(valor1, valor2);

        // assert
        Assert.Equal(5, resultadoSubtracao);

    }
}