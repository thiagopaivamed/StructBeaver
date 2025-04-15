using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class MergeSortTest
    {
        private readonly MergeSort _mergeSort;

        public MergeSortTest()
            => _mergeSort = new MergeSort();

        [Fact]
        public void MergeSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int[] vetorOrdenado = _mergeSort.Sort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        private void MostrarVetorOrdenado(int[] vetorOrdenado)
        {
            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                Assert.True(vetorOrdenado[indice] <= vetorOrdenado[indice + 1]);

            Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenado)}.");
        }
    }
}
