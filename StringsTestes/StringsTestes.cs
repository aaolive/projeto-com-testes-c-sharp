using Calculadora.Services;

namespace StringsTestes
{
    public class StringsTestes
    {
        private ValidacaoString validacaoDeStrings; // instância da classe que será testada

        public StringsTestes()
        {
            validacaoDeStrings = new ValidacaoString();
        }

        [Fact]
        public void ContaO_TextoBomDia_DeveRetornar6caracteres()
        {
            //arrange: valores para testar
            string texto = "BomDia";

            // act: faz o teste na classe que tem o codigo que será testado
            int quantidadeDeCaracteres = validacaoDeStrings.ContarQuantidadeDeCaracteres(texto);

            //assert: verifica o resultado
            Assert.Equal(6, quantidadeDeCaracteres);
            
        }
    }
}
