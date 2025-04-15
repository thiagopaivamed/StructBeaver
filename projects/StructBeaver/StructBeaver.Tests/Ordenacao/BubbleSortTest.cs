using StructBeaver.Ordenacao;

namespace StructBeaver.Tests.Ordenacao
{
    public class BubbleSortTest
    {
        private readonly BubbleSort _bubbleSort;

        public BubbleSortTest()
            => _bubbleSort = new BubbleSort();

        [Fact]
        public void BubbleSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _bubbleSort.Sort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void BubbleSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _bubbleSort.RecursiveSort(vetorDesordenado, quantidadeElementos);

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
