using Calculadora;

namespace TestCalculadora
{
    public class OperacoesBasicasTest
    {
        private readonly OperacoesBasicas _operacoes = new();

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void SomarTest(int a, int b, int resultadoEsperado)
        {
            // Arrange
            int resultado = 0;

            // Act
            resultado = _operacoes.Somar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 5, 4)]
        public void SubtrairTest(int a, int b, int resultadoEsperado)
        {
            // Arrange
            int resultado = 0;

            // Act
            resultado = _operacoes.Subtrair(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(4, 2, 8)]
        public void MultiplicarTest(int a, int b, int resultadoEsperado)
        {
            // Arrange
            int resultado = 0;

            // Act
            resultado = _operacoes.Multiplicar(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(6, 3, 2)]
        public void DividirTest(int a, int b, int resultadoEsperado)
        {
            // Arrange
            int resultado = 0;

            // Act
            resultado = _operacoes.Dividir(a, b);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DividirPorZeroTest()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => _operacoes.Dividir(a, b));
        }

        [Fact]
        public void HistoricoTest()
        {
            // Arrange
            int a = 6;
            int b = 3;
            List<string> listaHistorico;

            // Act
            int resultado1 = _operacoes.Somar(a, b);
            int resultado2 = _operacoes.Subtrair(a, b);
            int resultado3 = _operacoes.Multiplicar(a, b);
            int resultado4 = _operacoes.Dividir(a, b);

            listaHistorico = _operacoes.Historico();

            // Assert
            Assert.NotEmpty(listaHistorico);
            Assert.Equal(3, listaHistorico.Count);
        }
    }
}