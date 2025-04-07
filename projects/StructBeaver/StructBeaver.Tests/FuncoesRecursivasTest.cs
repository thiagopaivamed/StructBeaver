using Recursividade;

namespace StructBeaver.Tests
{
    public class FuncoesRecursivasTest
    {
        private FuncoesRecursivas _funcoesRecursivas;

        public FuncoesRecursivasTest() =>
            _funcoesRecursivas = new FuncoesRecursivas();

        [Fact]
        public void Fatorial_Deve_Retornar_MenosUm()
        {
            int numero = -99;

            int fatorial = _funcoesRecursivas.Fatorial(numero);

            Assert.True(fatorial is -1);

            Console.WriteLine($"Não existe fatorial de numeros negativos, portanto, foi retornado {fatorial}.");
        }

        [Fact]
        public void Fatorial_Deve_Retornar_Zero_Ou_Um()
        {
            int numero = 0;

            int fatorial = _funcoesRecursivas.Fatorial(numero);

            Assert.True(fatorial is 0 or 1);

            Console.WriteLine($"O fatorial de 0 ou 1 é {fatorial}.");
        }

        [Fact]
        public void Fatorial_Deve_Retornar_Valor_Calculado()
        {
            int numero = 6;

            int fatorial = _funcoesRecursivas.Fatorial(numero);

            Assert.True(fatorial is 720);

            Console.WriteLine($"O fatorial de {numero} é {fatorial}.");
        }

        [Fact]
        public void Fibonacci_Deve_Retornar_Zero_Ou_Um()
        {
            int numeroSequencia = 0;

            int fibonacci = _funcoesRecursivas.Fibonacci(numeroSequencia);

            Assert.True(fibonacci == numeroSequencia);
        
            Console.WriteLine($"O {numeroSequencia}° termo da sequência de fibonacci é {fibonacci}.");
        }

        [Fact]
        public void Fibonacci_Deve_Retornar_Valor_Calculado()
        {
            int numeroSequencia = 4;

            int fibonacci = _funcoesRecursivas.Fibonacci(numeroSequencia);

            Assert.True(fibonacci is not 0 or 1);

            Console.WriteLine($"O {numeroSequencia}° termo da sequência de fibonacci é {fibonacci}.");
        }

    }
}
