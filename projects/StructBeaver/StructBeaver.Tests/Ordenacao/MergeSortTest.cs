using Shouldly;
using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class MergeSortTest
    {
        private readonly MergeSort _mergeSort;

        public MergeSortTest()
            => _mergeSort = new();

        [Fact]
        public void MergeSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int[] vetorOrdenado = _mergeSort.Sort(vetorDesordenado);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }        
    }
}