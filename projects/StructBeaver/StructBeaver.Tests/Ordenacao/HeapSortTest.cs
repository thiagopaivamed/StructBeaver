using Shouldly;
using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class HeapSortTest
    {
        private readonly HeapSort _heapSort;

        public HeapSortTest()
            => _heapSort = new HeapSort();        

        [Fact]
        public void Deve_Ordenar_Array_Com_Multiplos_Elementos()
        {
            int[] array = [5, 3, 8, 4, 1, 2];
            int[] esperado = [1, 2, 3, 4, 5, 8];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }

        [Fact]
        public void Deve_Ordenar_Array_Com_Elemento_Unico()
        {
            int[] array = [7];
            int[] esperado = [7];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }

        [Fact]
        public void Deve_Ordenar_Array_Vazio()
        {
            int[] array = [];
            int[] esperado = [];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }

        [Fact]
        public void Deve_Ordenar_Array_Ja_Ordenado()
        {
            int[] array = [1, 2, 3, 4, 5];
            int[] esperado = [1, 2, 3, 4, 5];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }

        [Fact]
        public void Deve_Ordenar_Array_Em_Ordem_Decrescente()
        {
            int[] array = [9, 7, 5, 3, 1];
            int[] esperado = [1, 3, 5, 7, 9];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }

        [Fact]
        public void Deve_Ordenar_Array_Com_Elementos_Repetidos()
        {
            int[] array = [4, 2, 4, 3, 2];
            int[] esperado = [2, 2, 3, 4, 4];

            _heapSort.Sort(array);

            array.ShouldBe(esperado);
        }
    }
}
