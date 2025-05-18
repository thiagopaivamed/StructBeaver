using Shouldly;
using StructBeaver.Recursividade;

namespace StructBeaver.Tests.Recursividade
{
    public class FatorialTest
    {
        private readonly Fatorial _fatorial;

        public FatorialTest()  
            => _fatorial = new();

        [Fact]
        public void Fatorial_Deve_Retornar_MenosUm()
        {
            int numero = -99;

            int fatorial = _fatorial.CalcularFatorial(numero);

            fatorial.ShouldBe(-1);
        }

        [Fact]
        public void Fatorial_Deve_Retornar_1_Quando_Numero_For_0()
        {
            int resultado = _fatorial.CalcularFatorial(0);
            resultado.ShouldBe(1);
        }

        [Fact]
        public void Fatorial_Deve_Retornar_1_Quando_Numero_For_1()
        {
            int resultado = _fatorial.CalcularFatorial(1);
            resultado.ShouldBe(1);
        }

        [Fact]
        public void Fatorial_Deve_Retornar_Valor_Calculado()
        {
            int numero = 6;

            int fatorial = _fatorial.CalcularFatorial(numero);

            fatorial.ShouldBe(720);
        }
    }
}