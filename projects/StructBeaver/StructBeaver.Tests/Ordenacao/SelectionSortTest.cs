using Shouldly;
using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class SelectionSortTest
    {
        private readonly SelectionSort _selectionSort;

        public SelectionSortTest()
            => _selectionSort = new();

        [Fact]
        public void SelectionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _selectionSort.Sort(vetorDesordenado);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }

        [Fact]
        public void SelectionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _selectionSort.RecursiveSort(vetorDesordenado, quantidadeElementos);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }        
    }
}