using Shouldly;
using StructBeaver.Ordenacao.Exercicios;

namespace StructBeaver.Tests.Ordenacao.Exercicios
{
    public class BubbleSortRecursivoCrescenteDecrescenteTest
    {
        private readonly BubbleSortRecursivoCrescenteDecrescente _bubbleSortRecursivoCrescenteDecrescente;

        public BubbleSortRecursivoCrescenteDecrescenteTest()
            => _bubbleSortRecursivoCrescenteDecrescente = new();

        [Fact]
        public void BubbleSortRecursivoCrescenteDecrescente_Deve_Retornar_Vetor_Ordenado_Em_Ordem_Crescente()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;
            bool ordemCrescente = true;

            int[] vetorOrdenado = _bubbleSortRecursivoCrescenteDecrescente.OrdenarRecursivamente(vetorDesordenado, quantidadeElementos, ordemCrescente);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }

        [Fact]
        public void BubbleSortRecursivoCrescenteDecrescente_Deve_Retornar_Vetor_Ordenado_Em_Ordem_Decrescente()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
            int quantidadeElementos = vetorDesordenado.Length;
            bool ordemCrescente = false;

            int[] vetorOrdenadoDecrescente = _bubbleSortRecursivoCrescenteDecrescente.OrdenarRecursivamente(vetorDesordenado, quantidadeElementos, ordemCrescente);

            for (int indice = 0; indice < vetorOrdenadoDecrescente.Length - 1; indice++)
                vetorOrdenadoDecrescente[indice].ShouldBeGreaterThanOrEqualTo(vetorOrdenadoDecrescente[indice + 1]);
        }
    }
}