using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class QuickSortTest
    {
        private readonly QuickSort _quickSort;

        public QuickSortTest()
            => _quickSort = new QuickSort();

        [Fact]
        public void QuickSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _quickSort.Sort(vetorDesordenado, 0, vetorDesordenado.Length - 1);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                Assert.True(vetorOrdenado[indice] <= vetorOrdenado[indice + 1]);
        }
    }
}