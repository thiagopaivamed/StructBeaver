using Ordenacao;

namespace StructBeaver.Tests
{
    public class MetodosOrdenacaoTest
    {
        private MetodosOrdenacao _metodosOrdenacao;

        public MetodosOrdenacaoTest()
            => _metodosOrdenacao = new MetodosOrdenacao();

        [Fact]
        public void BubbleSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _metodosOrdenacao.BubbleSort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void BubbleSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _metodosOrdenacao.BubbleSortRecursivo(vetorDesordenado, quantidadeElementos);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void SelectionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _metodosOrdenacao.SelectionSort(vetorDesordenado);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void SelectionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;

            int[] vetorOrdenado = _metodosOrdenacao.SelectionSortRecursivo(vetorDesordenado, quantidadeElementos);

            MostrarVetorOrdenado(vetorOrdenado);
        }

        [Fact]
        public void InsertionSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _metodosOrdenacao.InsertionSort(vetorDesordenado);

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
