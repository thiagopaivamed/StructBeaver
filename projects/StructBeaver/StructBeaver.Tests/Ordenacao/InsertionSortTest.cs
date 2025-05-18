using Shouldly;
using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class InsertionSortTest
    {
        private readonly InsertionSort _insertionSort;

        public InsertionSortTest()
            => _insertionSort = new();

        [Fact]
        public void InsertionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _insertionSort.Sort(vetorDesordenado);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }

        [Fact]
        public void InsertionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _insertionSort.RecursiveSort(vetorDesordenado, vetorDesordenado.Length);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }
    }
}