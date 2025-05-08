using StructBeaver.Recursividade;

namespace StructBeaver.Tests.Recursividade
{
    public class FibonacciTest
    {
        private readonly Fibonacci _fibonacci;

        public FibonacciTest()
            => _fibonacci = new Fibonacci();

        [Fact]
        public void Fibonacci_Deve_Retornar_Zero_Ou_Um()
        {
            int numeroSequencia = 0;

            int fibonacci = _fibonacci.CalcularFibonacci(numeroSequencia);

            Assert.True(fibonacci == numeroSequencia);
        }

        [Fact]
        public void Fibonacci_Deve_Retornar_Valor_Calculado()
        {
            int numeroSequencia = 4;

            int fibonacci = _fibonacci.CalcularFibonacci(numeroSequencia);

            Assert.True(fibonacci is not 0 or 1);
        }
    }
}