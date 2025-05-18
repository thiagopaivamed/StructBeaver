using Shouldly;
using StructBeaver.Recursividade;

namespace StructBeaver.Tests.Recursividade
{
    public class FibonacciTest
    {
        private readonly Fibonacci _fibonacci;

        public FibonacciTest()
            => _fibonacci = new();

        [Fact]
        public void Fibonacci_Deve_Retornar_Zero_Ou_Um()
        {
            int numeroSequencia = 0;

            int fibonacci = _fibonacci.CalcularFibonacci(numeroSequencia);

            fibonacci.ShouldBe(numeroSequencia);
        }

        [Fact]
        public void Fibonacci_Deve_Retornar_Valor_Calculado()
        {
            int numeroSequencia = 4;

            int fibonacci = _fibonacci.CalcularFibonacci(numeroSequencia);

            fibonacci.ShouldNotBe(0);
            fibonacci.ShouldNotBe(1);
        }
    }
}