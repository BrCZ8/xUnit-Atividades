namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(5, CalculadoraExample.Calculadora.Somar(2, 3));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(2, CalculadoraExample.Calculadora.Subtrair(5, 3));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(6, CalculadoraExample.Calculadora.Dividir(12, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(9, CalculadoraExample.Calculadora.Multiplicar(3, 3));
        }
    }
}