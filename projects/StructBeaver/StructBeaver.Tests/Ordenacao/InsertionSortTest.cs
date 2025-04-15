using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class InsertionSortTest
    {
        private readonly InsertionSort _insertionSort;

        public InsertionSortTest()
            => _insertionSort = new InsertionSort();

        [Fact]
        public void InsertionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _insertionSort.Sort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void InsertionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _insertionSort.RecursiveSort(vetorDesordenado, vetorDesordenado.Length);

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
