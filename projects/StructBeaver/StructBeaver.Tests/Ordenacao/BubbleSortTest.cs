using Shouldly;
using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class BubbleSortTest
    {
        private readonly BubbleSort _bubbleSort;

        public BubbleSortTest()
            => _bubbleSort = new();

        [Fact]
        public void BubbleSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _bubbleSort.Sort(vetorDesordenado);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }

        [Fact]
        public void BubbleSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _bubbleSort.RecursiveSort(vetorDesordenado, quantidadeElementos);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }
    }
}