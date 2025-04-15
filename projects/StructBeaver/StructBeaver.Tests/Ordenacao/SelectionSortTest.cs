using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class SelectionSortTest
    {
        private readonly SelectionSort _selectionSort;

        public SelectionSortTest()
            => _selectionSort = new SelectionSort();

        [Fact]
        public void SelectionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _selectionSort.Sort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void SelectionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _selectionSort.RecursiveSort(vetorDesordenado, quantidadeElementos);

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
