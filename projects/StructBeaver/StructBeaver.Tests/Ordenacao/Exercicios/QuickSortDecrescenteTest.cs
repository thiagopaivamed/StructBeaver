using StructBeaver.Ordenacao.Exercicios;

namespace StructBeaver.Tests.Ordenacao.Exercicios
{
    public class QuickSortDecrescenteTest
    {
        private QuickSortDecrescente _quickSortDecrescente;

        public QuickSortDecrescenteTest()
            => _quickSortDecrescente = new QuickSortDecrescente();

        [Fact]
        public void QuickSortDecrescente_Deve_Retornar_Vetor_Ordenado_Em_Ordem_Decrescente()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenadoDecrescente = _quickSortDecrescente.Ordenar(vetorDesordenado, 0, vetorDesordenado.Length -1);

            for (int indice = 0; indice < vetorOrdenadoDecrescente.Length - 1; indice++)
                Assert.True(vetorOrdenadoDecrescente[indice] >= vetorOrdenadoDecrescente[indice + 1]);

            Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenadoDecrescente)}.");
        }
    }
}
