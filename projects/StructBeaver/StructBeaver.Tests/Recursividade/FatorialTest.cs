using StructBeaver.Recursividade;

namespace StructBeaver.Tests.Recursividade
{
    public class FatorialTest
    {
        private readonly Fatorial _fatorial;

        public FatorialTest()  
            => _fatorial = new Fatorial();

        [Fact]
        public void Fatorial_Deve_Retornar_MenosUm()
        {
            int numero = -99;

            int fatorial = _fatorial.CalcularFatorial(numero);

            Assert.True(fatorial is -1);
        }

        [Fact]
        public void Fatorial_Deve_Retornar_Zero_Ou_Um()
        {
            int numero = 0;

            int fatorial = _fatorial.CalcularFatorial(numero);

            Assert.True(fatorial is 0 or 1);

            Console.WriteLine($"O fatorial de 0 ou 1 é {fatorial}.");
        }

        [Fact]
        public void Fatorial_Deve_Retornar_Valor_Calculado()
        {
            int numero = 6;

            int fatorial = _fatorial.CalcularFatorial(numero);

            Assert.True(fatorial is 720);
        }
    }
}