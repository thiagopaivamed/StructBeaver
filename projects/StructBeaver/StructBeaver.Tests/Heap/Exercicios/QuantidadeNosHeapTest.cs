using Shouldly;
using StructBeaver.Heap.Exercicios;

namespace StructBeaver.Tests.Heap.Exercicios
{
    public class QuantidadeNosHeapTest
    {
        private readonly QuantidadeNosHeap _quantidadeNosHeap;

        public QuantidadeNosHeapTest()
            => _quantidadeNosHeap = new();

        [Theory]
        [InlineData(0, 1, 1)]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 7)]
        [InlineData(3, 8, 15)]
        [InlineData(4, 16, 31)]
        [InlineData(5, 32, 63)]
        public void Deve_Retornar_Minimo_E_Maximo_Numero_De_Nos_Para_Altura(int altura, int minimoEsperado, int maximoEsperado)
        {
            (int Minimo, int Maximo) resultado = _quantidadeNosHeap.PegarQuantidadeDeNosPossiveis(altura);

            resultado.Minimo.ShouldBe(minimoEsperado);
            resultado.Maximo.ShouldBe(maximoEsperado);
        }

        [Fact]
        public void Deve_Lancar_Excecao_Quando_Altura_For_Negativa()
            => Should.Throw<ArgumentOutOfRangeException>(() => _quantidadeNosHeap.PegarQuantidadeDeNosPossiveis(-1));
    }
}