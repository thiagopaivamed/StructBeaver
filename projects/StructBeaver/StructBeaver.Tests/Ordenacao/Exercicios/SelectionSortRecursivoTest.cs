using Shouldly;
using StructBeaver.Ordenacao.Exercicios;

namespace StructBeaver.Tests.Ordenacao.Exercicios
{
    public class SelectionSortRecursivoTest
    {
        private readonly SelectionSortRecursivo _selectionSortRecursivo;

        public SelectionSortRecursivoTest()
            => _selectionSortRecursivo = new();

        [Fact]
        public void SelectionSortRecursivo_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

            int[] vetorOrdenado = _selectionSortRecursivo.OrdenarRecursivamente(vetorDesordenado);

            for (int indice = 0; indice < vetorOrdenado.Length - 1; indice++)
                vetorOrdenado[indice].ShouldBeLessThanOrEqualTo(vetorOrdenado[indice + 1]);
        }
    }
}