using System.Runtime.Intrinsics.Arm;
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

    [Fact]
    public void TestaMetodoQueDizSeUmNumeroEhPar()
    {
        // arrange
        var numero = 2;
        // act
        bool resultadoDoTesteParOuNao = calculadora.ehPar(numero);
        // assert
        Assert.True(resultadoDoTesteParOuNao);
    }

    /*
    Devemos usar [Theory] para e [InlineData(valor)] para testar varias vezes
    */
    [Theory]
    [InlineData(2)]
    [InlineData(6)]
    [InlineData(10)]
    [InlineData(202)]
    [InlineData(176)]
    [InlineData(80)]
    public void TestaSeVariosNumerosSaoPares(int numero){

        // act
        bool resultadoDosNumerosDoTesteParOuNao=calculadora.ehPar(numero);
        //assert
        Assert.True(resultadoDosNumerosDoTesteParOuNao);

    }

    /*
    Usando Assert.All() para testar varios casos sem usar [InlineData(valor)]
    */
    [Theory]
    [InlineData(new int[]{12,14,100})]
    public void TestaSeVariosNumerosSaoParesComArray(int[] numeros){
        // para isso usar Assert.All()
        Assert.All(numeros, num => Assert.True(calculadora.ehPar(num)));
    }
}