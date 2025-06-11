using Shouldly;
using StructBeaver.Heap.Exercicios;

namespace StructBeaver.Tests.Heap.Exercicios
{
    public class K_esimoMaiorComHeapTest
    {
        private readonly K_esimoMaiorComHeap _k_esimoMaiorComHeap;

        public K_esimoMaiorComHeapTest()        
            => _k_esimoMaiorComHeap = new();        

        [Fact]
        public void Deve_Retornar_K_Esimo_Maior_Elemento()
        {
            int[] array = { 5, 3, 8, 1, 10, 7 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 3);

            resultado.ShouldBe(7);
        }

        [Fact]
        public void Deve_Retornar_Maior_Elemento_Quando_K_Igual_A_Um()
        {
            int[] array = { 4, 15, 6, 9, 2 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 1);

            resultado.ShouldBe(15);
        }

        [Fact]
        public void Deve_Retornar_Nulo_Quando_Array_For_Nulo()
        {
            int[] array = null!;
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 2);

            resultado.ShouldBeNull();
        }

        [Fact]
        public void Deve_Retornar_Nulo_Quando_K_Maior_Que_Tamanho_Do_Array()
        {
            int[] array = { 1, 2 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 3);

            resultado.ShouldBeNull();
        }

        [Fact]
        public void Deve_Retornar_Nulo_Quando_K_For_Menor_Ou_Igual_A_Zero()
        {
            int[] array = { 4, 5, 6 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 0);

            resultado.ShouldBeNull();
        }

        [Fact]
        public void Deve_Funcionar_Com_Elementos_Duplicados()
        {
            int[] array = { 5, 3, 5, 2, 8, 8, 1 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 2);

            resultado.ShouldBe(8);
        }

        [Fact]
        public void Deve_Funcionar_Com_Array_Com_Um_Elemento()
        {
            int[] array = { 42 };
            int? resultado = _k_esimoMaiorComHeap.PegarK_esimoMaior(array, 1);

            resultado.ShouldBe(42);
        }
    }
}